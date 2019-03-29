namespace WildFarm.Classes.Animals.Mammals.Felines
{
    using System;
    using WildFarm.Classes.Foods;

    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightPerFood => 0.3;

        public override string MakeSound()
        {
            return "Meow";
        }

        public override void Feed(Food food)
        {
            if (food.GetType().Name != "Meat" && food.GetType().Name != "Vegetable")
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            base.Feed(food);
        }
    }
}
