using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_and_Subtract
{
    public class Program
    {
        public static void Main()
        {
            PrintSubstract(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        public static int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public static void PrintSubstract(int numberOne, int numberTwo, int numberThree)
        {
            Console.WriteLine(Sum(numberOne, numberTwo) - numberThree);
        }
    }
}
