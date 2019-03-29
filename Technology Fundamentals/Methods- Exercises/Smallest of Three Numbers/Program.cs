using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_of_Three_Numbers
{
    public class Program
    {
        public static void Main()
        {
            PrintSmallestNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        public static void PrintSmallestNumber(int numberOne, int numberTwo, int numberThree)
        {
            Console.WriteLine(Math.Min(numberOne, Math.Min(numberTwo, numberThree)));
        }
    }
}
