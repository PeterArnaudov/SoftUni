using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    public class Program
    {
        public static void Main()
        {
            int max = GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(max);
        }

        public static int GetMax(int numberOne, int numberTwo, int numberThree)
        {
            return Math.Max(numberOne, Math.Max(numberTwo, numberThree));
        }
    }
}
