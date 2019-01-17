using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Program
    {
        public static void Main()
        {
            PrintGrade(double.Parse(Console.ReadLine()));
        }

        public static void PrintGrade(double grade)
        {
            string output = string.Empty;

            if (grade >= 2 && grade <= 2.99)
            {
                output = "Fail";
            }
            else if (grade >= 3 && grade <= 3.49)
            {
                output = "Poor";
            }
            else if (grade >= 3.5 && grade <= 4.49)
            {
                output = "Good";
            }
            else if (grade >= 4.5 && grade <= 5.49)
            {
                output = "Very good";
            }
            else if (grade >= 5.5 && grade <= 6)
            {
                output = "Excellent";
            }

            Console.WriteLine(output);
        }
    }
}
