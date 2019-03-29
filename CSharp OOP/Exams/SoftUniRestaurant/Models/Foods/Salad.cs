﻿namespace SoftUniRestaurant.Models.Foods
{
    using System;

    public class Salad : Food
    {
        private const int InitialServingSize = 300;

        public Salad(string name, decimal price) 
            : base(name, InitialServingSize, price)
        {
        }
    }
}
