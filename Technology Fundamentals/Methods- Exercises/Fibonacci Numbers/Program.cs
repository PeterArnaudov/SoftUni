using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int[] fibonacciNumbers = FibonacciNumber(int.Parse(Console.ReadLine()));

            Console.WriteLine(fibonacciNumbers.Last());
        }

        public static int[] FibonacciNumber(int number)
        {
            int[] fibonacciNumbers = new int[number + 1];
            fibonacciNumbers[0] = 1;

            if (number >= 1)
                fibonacciNumbers[1] = 1;

            if (number >= 2)
                for (int i = 2; i < fibonacciNumbers.Length; i++)
                    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];

            return fibonacciNumbers;
        }
    }
}
