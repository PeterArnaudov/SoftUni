using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    public class Program
    {
        public static void Main()
        {
                bool isPrime = PrimeOrNot(long.Parse(Console.ReadLine()));

                Console.WriteLine(isPrime);
        }

        public static bool PrimeOrNot(long number)
        {
            if (number == 0 || number == 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
