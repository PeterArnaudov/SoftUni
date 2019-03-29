using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            bool weekend = dayOfWeek == "Saturday" || dayOfWeek == "Sunday";
            bool workDay = dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday";
            bool fruit = product == "banana" || product == "apple" || product == "orange" || product == "grapefruit" || product == "kiwi" || product == "pineapple" || product == "grapes";

            double price = 1;
            string exit = string.Empty;

            if (workDay)
            {
                if (product == "banana")
                    price = 2.5;
                else if (product == "apple")
                    price = 1.2;
                else if (product == "orange")
                    price = 0.85;
                else if (product == "grapefruit")
                    price = 1.45;
                else if (product == "kiwi")
                    price = 2.7;
                else if (product == "pineapple")
                    price = 5.5;
                else if (product == "grapes")
                    price = 3.85;
                else
                    Console.WriteLine("error");
            }
            else if (weekend)
            {
                if (product == "banana")
                    price = 2.7;
                else if (product == "apple")
                    price = 1.25;
                else if (product == "orange")
                    price = 0.9;
                else if (product == "grapefruit")
                    price = 1.6;
                else if (product == "kiwi")
                    price = 3;
                else if (product == "pineapple")
                    price = 5.6;
                else if (product == "grapes")
                    price = 4.2;
                else
                    Console.WriteLine("error");
            }
            else
                Console.WriteLine("error");

            double totalPrice = price * quantity;

            if ((weekend || workDay) && fruit)
                Console.WriteLine($"{totalPrice:f2}");
        } 
    }
}
