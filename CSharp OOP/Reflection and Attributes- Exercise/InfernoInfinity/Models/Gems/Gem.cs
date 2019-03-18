namespace InfernoInfinity.Models.Gems
{
    using InfernoInfinity.Interfaces;
    using System;

    public abstract class Gem : IGem
    {
        private Clarity clarity;
        private int strength;
        private int agility;
        private int vitality;

        public Gem(string clarity, int strength, int agility, int vitality)
        {
            this.clarity = Enum.Parse<Clarity>(clarity);
            this.strength = strength + (int)this.clarity;
            this.agility = agility + (int)this.clarity;
            this.vitality = vitality + (int)this.clarity;
        }

        public int Strength => this.strength;

        public int Agility => this.agility;

        public int Vitality => this.vitality;
    }
}
