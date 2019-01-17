using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isEven = number % 2 == 0;
            string EvenOdd = string.Empty;

            if (isEven)
                EvenOdd = "even";
            else
                EvenOdd = "odd";

            Console.WriteLine(EvenOdd);
        }
    }
}
