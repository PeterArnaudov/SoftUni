using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Shelter
{
    class Program
    {
        static void Main()
        {
            // Programming Basics Online Exam - 16 and 17 June 2018
            // 15:00 - 15:15 <15 min>
            // 100/100

            int foodBought = int.Parse(Console.ReadLine()) * 1000;
            int foodEaten = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Adopted")
                {
                    break;
                }
                else
                {
                    int foodPerMeal = int.Parse(command);
                    foodEaten += foodPerMeal;
                }
            }

            if (foodBought >= foodEaten)
                Console.WriteLine($"Food is enough! Leftovers: {foodBought - foodEaten} grams.");
            else
                Console.WriteLine($"Food is not enough. You need {foodEaten - foodBought} grams more.");
        }
    }
}
