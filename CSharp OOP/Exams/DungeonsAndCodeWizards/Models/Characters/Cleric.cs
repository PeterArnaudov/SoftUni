namespace DungeonsAndCodeWizards.Models.Characters
{
    using DungeonsAndCodeWizards.Contracts;
    using DungeonsAndCodeWizards.Models.Bags;
    using DungeonsAndCodeWizards.Models.Enums;
    using System;

    public class Cleric : Character, IHealable
    {
        private const int ClericBaseHealth = 50;
        private const int ClericBaseArmor = 25;
        private const int ClericAbilityPoints = 40;

        public Cleric(string name, Faction faction) 
            : base(name, ClericBaseHealth, ClericBaseArmor, ClericAbilityPoints, new Backpack(), faction)
        {
            this.RestHealMultiplier = 0.5;
        }

        public void Heal(Character character)
        {
            if (!this.IsAlive || !character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (this.Faction != character.Faction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }

            character.Health += this.AbilityPoints;
        }
    }
}
