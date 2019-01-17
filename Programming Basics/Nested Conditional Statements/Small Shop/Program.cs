using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            bool coffee = product == "coffee";
            bool water = product == "water";
            bool beer = product == "beer";
            bool sweets = product == "sweets";
            bool peanuts = product == "peanuts";

            double price = 1;

            if (city == "Sofia")
            {
                if (coffee)
                    price = 0.5;
                else if (water)
                    price = 0.8;
                else if (beer)
                    price = 1.2;
                else if (sweets)
                    price = 1.45;
                else if (peanuts)
                    price = 1.6;
            }
            else if (city == "Plovdiv")
            {
                if (coffee)
                    price = 0.4;
                else if (water)
                    price = 0.7;
                else if (beer)
                    price = 1.15;
                else if (sweets)
                    price = 1.3;
                else if (peanuts)
                    price = 1.5;
            }
            else if (city == "Varna")
            {
                if (coffee)
                    price = 0.45;
                else if (water)
                    price = 0.7;
                else if (beer)
                    price = 1.1;
                else if (sweets)
                    price = 1.35;
                else if (peanuts)
                    price = 1.55;
            }

            double totalPrice = price * quantity;
            Console.WriteLine(totalPrice);
        }
    }
}
