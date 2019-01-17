using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_System
{
    class Program
    {
        static void Main()
        {
            // Programming Basics Online Exam - 28 and 29 April 2018
            // 15:15 - 15:30 <15 min>
            // 100/100

            int courses = int.Parse(Console.ReadLine());

            double creditsReceived = 0;
            double gradeSum = 0;

            for (int i = 1; i <= courses; i++)
            {
                int creditsAndGrade = int.Parse(Console.ReadLine());

                double grade = creditsAndGrade % 10;
                double credits = creditsAndGrade / 10;

                if (grade == 2)
                    credits = 0;
                else if (grade == 3)
                    credits *= 0.5;
                else if (grade == 4)
                    credits *= 0.7;
                else if (grade == 5)
                    credits *= 0.85;
                else if (grade == 6)
                    credits *= 1;

                creditsReceived += credits;
                gradeSum += grade;
            }

            Console.WriteLine($"{creditsReceived:f2}");
            Console.WriteLine($"{gradeSum / courses:f2}");
        }
    }
}
