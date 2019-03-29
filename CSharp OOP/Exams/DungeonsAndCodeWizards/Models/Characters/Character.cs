namespace DungeonsAndCodeWizards.Models.Characters
{
    using DungeonsAndCodeWizards.Models.Bags;
    using DungeonsAndCodeWizards.Models.Enums;
    using DungeonsAndCodeWizards.Models.Items;
    using System;

    public abstract class Character
    {
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private double abilityPoints;
        private Bag bag;
        private Faction faction;
        private bool isAlive;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.IsAlive = true;
            this.Rounds = 0;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                this.name = value;
            }
        }

        public double BaseHealth
        {
            get => this.baseHealth;

            private set => this.baseHealth = value;
        }

        public double Health
        {
            get => this.health;

            set
            {
                if (value > this.baseHealth)
                {
                    value = baseHealth;
                }
                else if (value < 0)
                {
                    this.IsAlive = false;
                    value = 0;
                }

                this.health = value;
            }
        }

        public double BaseArmor
        {
            get => this.baseArmor;

            private set => this.baseArmor = value;
        }

        public double Armor
        {
            get => this.armor;

            set
            {
                if (value > this.baseArmor)
                {
                    value = baseArmor;
                }
                else if (value < 0)
                {
                    value = 0;
                }

                this.armor = value;
            }
        }

        public double AbilityPoints
        {
            get => this.abilityPoints;

            private set => this.abilityPoints = value;
        }

        public Bag Bag
        {
            get => this.bag;

            private set => this.bag = value;
        }

        public Faction Faction
        {
            get => this.faction;

            private set => this.faction = value;
        }

        public bool IsAlive
        {
            get
            {
                if (this.Health > 0)
                {
                    return true;
                }

                return false;
            }

            private set => this.isAlive = value;
        }

        public double RestHealMultiplier { get; protected set; } = 0.2;

        public int Rounds { get; set; }

        public void TakeDamage(double hitPoints)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            double damage = hitPoints - this.Armor;
            this.Armor -= hitPoints;

            if (damage > 0)
            {
                this.Health -= damage;
            }
        }

        public void Rest()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            character.ReceiveItem(item);
        }

        public void ReceiveItem(Item item)
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            this.Bag.AddItem(item);
        }
    }
}
