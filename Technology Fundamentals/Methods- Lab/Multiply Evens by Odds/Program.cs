using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main()
        {
            int multiplication = GetMultipleOfEvenAndOddSum(Math.Abs(int.Parse(Console.ReadLine())));
            Console.WriteLine(multiplication);
        }

        public static int EvenDigitsSum(int number)
        {
            int evenSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                    evenSum += lastDigit;

                number /= 10;
            }

            return (evenSum);
        }

        public static int OddDigitsSum(int number)
        {
            int oddSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                    oddSum += lastDigit;

                number /= 10;
            }

            return (oddSum);
        }

        public static int GetMultipleOfEvenAndOddSum(int number)
        {
            int evenSum = EvenDigitsSum(number);
            int oddSum = OddDigitsSum(number);
            return evenSum * oddSum;
        }
    }
}
