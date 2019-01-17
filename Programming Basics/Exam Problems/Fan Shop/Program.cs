using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan_Shop
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());

            double money = 0;

            for (int i = 1; i <= items; i++)
            {
                string itemType = Console.ReadLine();

                if (itemType == "hoodie")
                    money += 30;
                else if (itemType == "keychain")
                    money += 4;
                else if (itemType == "T-shirt")
                    money += 20;
                else if (itemType == "flag")
                    money += 15;
                else if (itemType == "sticker")
                    money += 1;
            }

            if (budget >= money)
                Console.WriteLine($"You bought {items} items and left with {budget - money} lv.");
            else
                Console.WriteLine($"Not enough money, you need {money - budget} more money.");
        }
    }
}
