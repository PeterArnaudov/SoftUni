namespace WildFarm.Classes.Animals.Birds
{
    using System;
    using WildFarm.Classes.Foods;

    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightPerFood => 0.35;

        public override string MakeSound()
        {
            return "Cluck";
        }

        public override void Feed(Food food)
        {
            base.Feed(food);
        }
    }
}
