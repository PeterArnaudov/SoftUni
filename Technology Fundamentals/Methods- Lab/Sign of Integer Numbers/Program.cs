using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Number
{
    public class Program
    {
        public static void Main()
        {
            IntegerSign(int.Parse(Console.ReadLine()));
        }
        public static void IntegerSign(int number)
        {
            if (number == 0)
                Console.WriteLine($"The number {number} is zero.");
            else if (number > 0)
                Console.WriteLine($"The number {number} is positive.");
            else
                Console.WriteLine($"The number {number} is negative.");
        }
    }
}