namespace SoftUniRestaurant.Models.Drinks
{
    using System;

    public class Juice : Drink
    {
        private const decimal JuicePrice = 1.80M;

        public Juice(string name, int servingSize, string brand) 
            : base(name, servingSize, JuicePrice, brand)
        {
        }
    }
}
