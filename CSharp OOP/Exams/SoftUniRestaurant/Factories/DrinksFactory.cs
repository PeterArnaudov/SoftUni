namespace SoftUniRestaurant.Factories
{
    using SoftUniRestaurant.Models.Drinks;
    using SoftUniRestaurant.Models.Drinks.Contracts;
    using System;

    public static class DrinksFactory
    {
        public static IDrink CreateDrink(string type, string name, int servingSize, string brand)
        {
            if (type == "Alcohol")
            {
                return new Alcohol(name, servingSize, brand);
            }
            else if (type == "FuzzyDrink")
            {
                return new FuzzyDrink(name, servingSize, brand);
            }
            else if (type == "Juice")
            {
                return new Juice(name, servingSize, brand);
            }
            else if (type == "Water")
            {
                return new Water(name, servingSize, brand);
            }

            return null;
        }
    }
}
