using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Time
{
    class Program
    {
        static void Main()
        {
            string sushiType = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char shipment = char.Parse(Console.ReadLine());

            bool sashimi = sushiType == "sashimi";
            bool maki = sushiType == "maki";
            bool uramaki = sushiType == "uramaki";
            bool temaki = sushiType == "temaki";

            double price = 1;

            if (restaurant == "Sushi Zone")
            {
                if (sashimi)
                    price = 4.99;
                else if (maki)
                    price = 5.29;
                else if (uramaki)
                    price = 5.99;
                else if (temaki)
                    price = 4.29;
            }
            else if (restaurant == "Sushi Time")
            {
                if (sashimi)
                    price = 5.49;
                else if (maki)
                    price = 4.69;
                else if (uramaki)
                    price = 4.49;
                else if (temaki)
                    price = 5.19;
            }
            else if (restaurant == "Sushi Bar")
            {
                if (sashimi)
                    price = 5.25;
                else if (maki)
                    price = 5.55;
                else if (uramaki)
                    price = 6.25;
                else if (temaki)
                    price = 4.75;
            }
            else if (restaurant == "Asian Pub")
            {
                if (sashimi)
                    price = 4.50;
                else if (maki)
                    price = 4.80;
                else if (uramaki)
                    price = 5.50;
                else if (temaki)
                    price = 5.50;
            }
            else
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
                return;
            }

            double totalMoney = portions * price;

            if (shipment == 'Y')
                totalMoney *= 1.2;

            Console.WriteLine($"Total price: {Math.Ceiling(totalMoney)} lv.");
        }
    }
}
