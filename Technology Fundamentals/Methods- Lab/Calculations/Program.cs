using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(numberOne, numberTwo);
                    break;
                case "multiply":
                    Multiply(numberOne, numberTwo);
                    break;
                case "substract":
                    Substract(numberOne, numberTwo);
                    break;
                case "divide":
                    Divide(numberOne, numberTwo);
                    break;
            }
        }

        public static void Add(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }

        public static void Multiply(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne * numberTwo);
        }

        public static void Substract(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne - numberTwo);
        }

        public static void Divide(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne / numberTwo);
        }
    }
}
