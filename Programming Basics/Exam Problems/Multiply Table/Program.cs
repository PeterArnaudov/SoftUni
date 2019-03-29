using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Table
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int hundreds = number / 100;
            int tenths = (number - (hundreds * 100) - (number % 10)) / 10;
            int ones = number % 10;

            for (int third = 1; third <= ones; third++)
            {
                for (int second = 1; second <= tenths; second++)
                {
                    for (int first = 1; first <= hundreds; first++)
                    {
                        int multiply = third * second * first;
                        Console.WriteLine($"{third} * {second} * {first} = {multiply};");
                    }
                }
            }
        }
    }
}
