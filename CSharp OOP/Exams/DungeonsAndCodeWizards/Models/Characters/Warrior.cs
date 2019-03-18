namespace DungeonsAndCodeWizards.Models.Characters
{
    using System;
    using DungeonsAndCodeWizards.Contracts;
    using DungeonsAndCodeWizards.Models.Bags;
    using DungeonsAndCodeWizards.Models.Enums;

    public class Warrior : Character, IAttackable
    {
        private const int WarriorBaseHealth = 100;
        private const int WarriorBaseArmor = 50;
        private const int WarriorAbilityPoints = 40;

        public Warrior(string name, Faction faction) 
            : base(name, WarriorBaseHealth, WarriorBaseArmor, WarriorAbilityPoints, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (this == character)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }

            if (this.Faction == character.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
            }

            character.TakeDamage(this.AbilityPoints);
        }
    }
}
