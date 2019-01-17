using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation_Part_2
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int grades = 1;
            double sum = 0;
            double failCounter = 0;

            while (true)
            {
                while (grades <= 12)
                {
                    double grade = double.Parse(Console.ReadLine());

                    if (grade >= 4)
                    {
                        sum += grade;
                        grades++;
                    }
                    else
                        failCounter++;

                    if (failCounter == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grades} grade");
                        break;
                    }
                }

                double average = sum / 12;

                if (average >= 4)
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");

                average = 0;
                failCounter = 0;
                grades = 1;
                sum = 0;
                name = Console.ReadLine();
                if (name == "END") return;
            }
        }
    }
}
