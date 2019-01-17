using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baking_Masterclass
{
    public class Program
    {
        public static void Main()
        {
            //09:06 - 
            double budget = double.Parse(Console.ReadLine());
            double students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double freeFlour = (students / 5);
            double extraApron = Math.Ceiling(students / 5.0);

            double floursToBuy = students - (int)freeFlour;
            double apronsToBuy = students + Math.Ceiling(extraApron);
            double eggsToBuy = students * 10;

            double floursMoney = floursToBuy * flourPrice;
            double eggsMoney = eggsToBuy * eggPrice;
            double apronMoney = apronsToBuy * apronPrice;
            double moneyNeeded = floursMoney + eggsMoney + apronMoney;

            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"Items purchased for {moneyNeeded:f2}$.");
            }
            else
            {
                Console.WriteLine($"{moneyNeeded - budget:f2}$ more needed.");
            }
        }
    }
}