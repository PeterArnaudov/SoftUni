namespace WildFarm.Classes.Animals.Mammals.Felines
{
    using System;

    public abstract class Feline : Mammal
    {
        private string breed;

        public Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.breed = breed;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
