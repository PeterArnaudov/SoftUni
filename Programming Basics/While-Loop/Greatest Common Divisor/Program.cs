using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor
{
    class Program
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            while (numberTwo != 0)
            {
                int oldNumberTwo = numberTwo;
                numberTwo = numberOne % numberTwo;
                numberOne = oldNumberTwo;
            }
            Console.WriteLine(numberOne);
        }
    }
}
