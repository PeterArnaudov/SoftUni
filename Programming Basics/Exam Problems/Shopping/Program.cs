using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        static void Main()
        {
            // Programming Basics Online Exam - 10 and 11 March 2018
            // 13:57 - 14:03 <6 min>
            // 100/100

            double budget = double.Parse(Console.ReadLine());
            int chocolateCount = int.Parse(Console.ReadLine());
            double milk = double.Parse(Console.ReadLine());

            double mandarin = Math.Floor(chocolateCount * 0.65);
            double moneyNeeded = (chocolateCount * 0.65 + milk * 2.7 + mandarin * 0.2);
            string exit = string.Empty;

            if (budget >= moneyNeeded)
                exit = $"You got this, {budget - moneyNeeded:f2} money left!";
            else
                exit = $"Not enough money, you need {moneyNeeded - budget:f2} more!";

            Console.WriteLine(exit);
        }
    }
}
