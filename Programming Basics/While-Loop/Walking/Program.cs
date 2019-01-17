using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Walking
{
    class Program
    {
        static void Main()
        {
            int currentSteps = 0;
            int finalSteps = 0;
            int steps = 0;
            string result = string.Empty;
            while (true)
            {
                string goingHome = Console.ReadLine();
                if (goingHome == "going home")
                {
                    finalSteps = int.Parse(Console.ReadLine());
                    steps += finalSteps;
                    break;
                }
                else
                    currentSteps = int.Parse(goingHome);
                steps += currentSteps;
                if (steps >= 9999)
                    break;
            }
            if (steps >= 10000)
            {
                result = "Goal reached! Good job!";
            }
            else
            {
                result = $"{10000 - steps} more steps to reach goal.";
            }
            Console.WriteLine(result);
        }
    }
}