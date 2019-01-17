using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Stage
{
    class Program
    {
        static void Main()
        {
            string teamName = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());

            int points = 0;
            int totalPositiveGoals = 0;
            int totalNegativeGoals = 0;

            for (int i = 1; i <= matches; i++)
            {
                int positiveGoals = int.Parse(Console.ReadLine());
                int negativeGoals = int.Parse(Console.ReadLine());

                if (positiveGoals > negativeGoals)
                    points += 3;
                else if (positiveGoals == negativeGoals)
                    points += 1;

                totalPositiveGoals += positiveGoals;
                totalNegativeGoals += negativeGoals;
            }

            if (totalPositiveGoals >= totalNegativeGoals)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {totalPositiveGoals - totalNegativeGoals}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {totalPositiveGoals - totalNegativeGoals}.");
            }
        }
    }
}
