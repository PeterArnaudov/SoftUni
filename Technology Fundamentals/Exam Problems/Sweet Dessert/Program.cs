using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    public class Program
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double kgBerriesPrice = double.Parse(Console.ReadLine());

            int numberOfDesserts = 0;
            if (guests % 6 == 0)
            {
                numberOfDesserts = guests / 6;
            }
            else
            {
                numberOfDesserts = guests / 6 + 1;
            }

            int bananasNeeded = 2 * numberOfDesserts;
            int eggsNeeded = 4 * numberOfDesserts;
            double berriesNeeded = 0.2 * numberOfDesserts;

            double moneyNeeded = (bananasNeeded * bananaPrice) + (eggsNeeded * eggPrice) + (berriesNeeded * kgBerriesPrice);

            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded - budget:f2}lv more.");
            }
        }
    }
}
