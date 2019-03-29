using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int gradesCount = 1;
            double grade = 0.0;
            double sumGrades = 0.0;
            double avarageGrade = 0.0;

            while (gradesCount <= 12)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sumGrades += grade;
                    gradesCount++;
                }
            }
            gradesCount--;
            avarageGrade = sumGrades / gradesCount;

            Console.WriteLine("{0} graduated. Average grade: {1:f2}", name, avarageGrade);
        }
    }
}
