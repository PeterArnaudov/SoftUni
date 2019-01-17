using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_and_Even_Position
{
    class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            for (int i = 1; i <= numbersCount; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > evenMax)
                        evenMax = number;
                    if (number < evenMin)
                        evenMin = number;
                }
                else
                {
                    oddSum += number;
                    if (number > oddMax)
                        oddMax = number;
                    if (number < oddMin)
                        oddMin = number;
                }
            }

            Console.WriteLine($"OddSum={oddSum}");

            if (oddMin == int.MaxValue)
                Console.WriteLine("OddMin=No");
            else
                Console.WriteLine($"OddMin={oddMin}");

            if (oddMax == int.MinValue)
                Console.WriteLine("OddMax=No");
            else
                Console.WriteLine($"OddMax={oddMax}");

            Console.WriteLine($"EvenSum={evenSum}");

            if (evenMin == int.MaxValue)
                Console.WriteLine("EvenMin=No");
            else
                Console.WriteLine($"EvenMin={evenMin}");

            if (evenMax == int.MinValue)
                Console.WriteLine("EvenMax=No");
            else
                Console.WriteLine($"EvenMax={evenMax}");
        }
    }
}
