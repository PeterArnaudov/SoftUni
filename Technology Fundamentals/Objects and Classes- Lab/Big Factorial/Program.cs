using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Big_Factorial
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = number;

            for (int i = number - 1; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
