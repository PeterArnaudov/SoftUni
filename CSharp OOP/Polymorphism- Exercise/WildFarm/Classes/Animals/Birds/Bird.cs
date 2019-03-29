namespace WildFarm.Classes.Animals.Birds
{
    using System;

    public abstract class Bird : Animal
    {
        private double wingSize;

        public Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.wingSize = wingSize;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.wingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
