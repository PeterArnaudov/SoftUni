namespace DungeonsAndCodeWizards.Core
{
    using DungeonsAndCodeWizards.Contracts;
    using DungeonsAndCodeWizards.Core.Factories;
    using DungeonsAndCodeWizards.Models.Characters;
    using DungeonsAndCodeWizards.Models.Items;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DungeonMaster
    {
        private List<Character> party;
        private List<Item> itemPool;

        public DungeonMaster()
        {
            this.party = new List<Character>();
            this.itemPool = new List<Item>();
        }

        public string JoinParty(string[] args)
        {
            string faction = args[0];
            string characterType = args[1];
            string name = args[2];

            this.party.Add(CharacterFactory.CreateCharacter(faction, characterType, name));
            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemType = args[0];

            this.itemPool.Add(ItemFactory.CreateItem(itemType));
            return $"{itemType} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            Character character = this.party.Find(c => c.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            if (!this.itemPool.Any())
            {
                throw new InvalidOperationException("No items left in pool!");
            }

            Item item = this.itemPool.Last();

            character.ReceiveItem(item);
            this.itemPool.RemoveAt(this.itemPool.Count - 1);

            return $"{characterName} picked up {item.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];

            Character character = this.party.FirstOrDefault(c => c.Name == characterName);
            character.Bag.GetItem(itemName);
            Item item = ItemFactory.CreateItem(itemName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            character.UseItem(item);

            return $"{character.Name} used {item.GetType().Name}.";
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            if (!this.party.Any(c => c.Name == giverName))
            {
                throw new ArgumentException($"Character {giverName} not found!");
            }
            if (!this.party.Any(c => c.Name == receiverName))
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }

            Character giver = this.party.Find(c => c.Name == giverName);
            Character receiver = this.party.Find(c => c.Name == receiverName);
            Item item = ItemFactory.CreateItem(itemName);

            giver.UseItemOn(item, receiver);

            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            if (!this.party.Any(c => c.Name == giverName))
            {
                throw new ArgumentException($"Character {giverName} not found!");
            }
            if (!this.party.Any(c => c.Name == receiverName))
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }

            Character giver = this.party.Find(c => c.Name == giverName);
            Character receiver = this.party.Find(c => c.Name == receiverName);
            Item item = ItemFactory.CreateItem(itemName);

            giver.GiveCharacterItem(item, receiver);

            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var character in this.party.OrderByDescending(c => c.IsAlive).ThenByDescending(c => c.Health))
            {
                string status = character.IsAlive ? "Alive" : "Dead";

                sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {status}");
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string receiverName = args[1];

            Character attacker = this.party.FirstOrDefault(c => c.Name == attackerName);
            Character receiver = this.party.FirstOrDefault(c => c.Name == receiverName);

            if (attacker == null)
            {
                throw new ArgumentException($"Character {attackerName} not found!");
            }
            if (receiver == null)
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }

            if (!(attacker is IAttackable))
            {
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }

            ((IAttackable)attacker).Attack(receiver);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (!receiver.IsAlive)
            {
                sb.AppendLine($"{receiverName} is dead!");
            }

            return sb.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string healingReceiverName = args[1];

            Character healer = this.party.FirstOrDefault(c => c.Name == healerName);
            Character receiver = this.party.FirstOrDefault(c => c.Name == healingReceiverName);

            if (healer == null)
            {
                throw new ArgumentException($"Character {healerName} not found!");
            }
            if (receiver == null)
            {
                throw new ArgumentException($"Character {healingReceiverName} not found!");
            }

            if (!(healer is IHealable))
            {
                throw new ArgumentException($"{healer.Name} cannot heal!");
            }

            ((IHealable)healer).Heal(receiver);

            return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
        }

        public string EndTurn(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var alive in this.party.Where(c => c.IsAlive))
            {
                double healthBefore = alive.Health;
                alive.Rest();
                sb.AppendLine($"{alive.Name} rests ({healthBefore} => {alive.Health})");
            }

            if (this.party.Where(c => c.IsAlive).Count() == 1)
            {
                this.party.Where(c => c.IsAlive).First().Rounds++;
            }

            return sb.ToString().TrimEnd();
        }

        public bool IsGameOver()
        {
            return this.party.Where(c => c.IsAlive).Count() == 1 && this.party.Where(c => c.IsAlive).First().Rounds == 2;
        }
    }
}
