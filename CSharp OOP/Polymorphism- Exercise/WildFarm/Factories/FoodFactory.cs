namespace WildFarm.Factories
{
    using System;
    using WildFarm.Classes.Foods;

    public static class FoodFactory
    {
        public static Food CreateFood(string[] info)
        {
            if (info[0] == "Vegetable")
            {
                return new Vegetable(int.Parse(info[1]));
            }
            else if (info[0] == "Fruit")
            {
                return new Fruit(int.Parse(info[1]));
            }
            else if (info[0] == "Meat")
            {
                return new Meat(int.Parse(info[1]));
            }
            else if (info[0] == "Seeds")
            {
                return new Seed(int.Parse(info[1]));
            }
            else
            {
                throw new ArgumentException("Invalid food type!");
            }
        }
    }
}
