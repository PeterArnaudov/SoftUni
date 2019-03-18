namespace SoftUniRestaurant.Models.Drinks
{
    using System;

    public class FuzzyDrink : Drink
    {
        private const decimal FuzzyDrinkPrice = 2.50M;

        public FuzzyDrink(string name, int servingSize, string brand) 
            : base(name, servingSize, FuzzyDrinkPrice, brand)
        {
        }
    }
}
