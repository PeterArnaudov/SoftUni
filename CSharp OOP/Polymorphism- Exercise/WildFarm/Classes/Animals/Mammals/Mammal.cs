namespace WildFarm.Classes.Animals.Mammals
{
    using System;

    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.livingRegion = livingRegion;
        }

        protected string LivingRegion => this.livingRegion;
    }
}
