namespace WildFarm.Classes.Animals.Birds
{
    using System;
    using WildFarm.Classes.Foods;

    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
                : base(name, weight, wingSize)
        {
        }

        protected override double WeightPerFood => 0.25;

        public override string MakeSound()
        {
            return "Hoot Hoot";
        }

        public override void Feed(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            base.Feed(food);
        }
    }
}
