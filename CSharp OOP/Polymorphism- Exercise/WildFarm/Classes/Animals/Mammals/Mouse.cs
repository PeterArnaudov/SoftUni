namespace WildFarm.Classes.Animals.Mammals
{
    using System;
    using WildFarm.Classes.Foods;

    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightPerFood => 0.1;

        public override string MakeSound()
        {
            return "Squeak";
        }

        public override void Feed(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            base.Feed(food);
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
