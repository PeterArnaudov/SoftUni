namespace WildFarm.Classes.Animals.Mammals.Felines
{
    using System;
    using WildFarm.Classes.Foods;

    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
                : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightPerFood => 1;

        public override string MakeSound()
        {
            return "ROAR!!!";
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
