namespace WildFarm.Classes.Animals
{
    using System;
    using WildFarm.Classes.Foods;

    public abstract class Animal
    {
        private string name;
        private double weight;
        private int foodEaten;

        public Animal(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
            this.foodEaten = 0;
        }

        protected abstract double WeightPerFood { get; }

        protected double Weight => this.weight;

        protected int FoodEaten => this.foodEaten;

        public virtual string MakeSound()
        {
            return "Base!";
        }

        public virtual void Feed(Food food)
        {
            this.weight += food.Quantity * this.WeightPerFood;
            this.foodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.name},";
        }
    }
}
