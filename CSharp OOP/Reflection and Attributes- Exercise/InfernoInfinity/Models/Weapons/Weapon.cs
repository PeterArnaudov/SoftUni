namespace InfernoInfinity.Models.Weapons
{
    using InfernoInfinity.CustomAttributes;
    using InfernoInfinity.Interfaces;
    using InfernoInfinity.Models.Gems;
    using System;
    using System.Linq;

    [Information("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public abstract class Weapon : IWeapon
    {
        private string name;
        private int minDamage;
        private int maxDamage;
        private IGem[] gems;
        private Rarity rarity;
        private int strength = 0;
        private int agility = 0;
        private int vitality = 0;

        public Weapon(string rarity, string name, int minDamage, int maxDamage, int sockets)
        {
            this.rarity = Enum.Parse<Rarity>(rarity);
            this.name = name;
            this.minDamage = minDamage * (int)this.rarity;
            this.maxDamage = maxDamage * (int)this.rarity;
            this.gems = new IGem[sockets];
        }

        public string Name => this.name;

        public int MinDamage
        {
            get
            {
                return this.minDamage + 2 * this.strength + this.agility;
            }
        }

        public int MaxDamage
        {
            get
            {
                return this.maxDamage + 3 * this.strength + 4 * this.agility;
            }
        }

        public void AddGem(IGem gem, int index)
        {
            if (index >= 0 && index < this.gems.Length)
            {
                if (this.gems[index] != null)
                {
                    this.strength -= this.gems[index].Strength;
                    this.agility -= this.gems[index].Agility;
                    this.vitality -= this.gems[index].Vitality;
                }
                this.gems[index] = gem;
                this.strength += gem.Strength;
                this.agility += gem.Agility;
                this.vitality += gem.Vitality;
            }
        }

        public void RemoveGem(int index)
        {
            if (index >= 0 && index < this.gems.Length && this.gems[index] != null)
            {
                this.strength -= this.gems[index].Strength;
                this.agility -= this.gems[index].Agility;
                this.vitality -= this.gems[index].Vitality;
                this.gems[index] = null;
            }
        }

        public override string ToString()
        {
            return $"{this.name}: {this.MinDamage}-{this.MaxDamage} Damage, " +
                $"+{this.strength} Strength, +{this.agility} Agility, +{this.vitality} Vitality";
        }
    }
}
