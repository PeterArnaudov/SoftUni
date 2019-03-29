namespace MordorsCruelPlan.Factories
{
    using MordorsCruelPlan.Factories.Foods;
    using System;

    public static class FoodFactory
    {
        public static Food GetFood(string item)
        {
            item = item.ToLower();

            if (item == "cram")
            {
                return new Cram();
            }
            else if (item == "lembas")
            {
                return new Lembas();
            }
            else if (item == "apple")
            {
                return new Apple();
            }
            else if (item == "melon")
            {
                return new Melon();
            }
            else if (item == "honeycake")
            {
                return new HoneyCake();
            }
            else if (item == "mushrooms")
            {
                return new Mushrooms();
            }
            else
            {
                return new Other();
            }
        } 
    }
}
