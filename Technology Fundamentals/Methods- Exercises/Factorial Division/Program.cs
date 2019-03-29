using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Division
{
    public class Program
    {
        public static void Main()
        {
            PrintFactorialDivision(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        public static long GetFactorial(int number)
        {
            number = Math.Abs(number);
            long factorial = number;

            for (int i = number - 1; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static void PrintFactorialDivision(int numberOne, int numberTwo)
        {
            double division = GetFactorial(numberOne) / (double)GetFactorial(numberTwo);
            Console.WriteLine($"{division:f2}");
        }
    }
}
