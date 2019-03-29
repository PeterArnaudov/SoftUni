using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Reception
{
    public class Program
    {
        public static void Main()
        {
            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int totalByHour = employeeOne + employeeTwo + employeeThree;

            int hoursNeeded = 0;
            int counter = 0;

            while (students > 0)
            {
                students -= totalByHour;
                hoursNeeded++;

                if (counter == 3)
                {
                    hoursNeeded++;
                    counter = 0;
                }

                counter++;
            }

            Console.WriteLine($"Time needed: {hoursNeeded}h.");
        }
    }
}
