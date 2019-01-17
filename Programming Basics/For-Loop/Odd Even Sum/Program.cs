using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                    evenSum += number;
                else
                    oddSum += number;
            }

            if (evenSum == oddSum)
                Console.WriteLine($"Yes Sum = {evenSum}");
            else
                Console.WriteLine($"No Diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}
