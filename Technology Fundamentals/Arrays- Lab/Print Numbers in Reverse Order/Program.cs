using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Numbers_in_Reverse_Order
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            for (int i = number - 1; i >= 0; i--)
                Console.Write($"{numbers[i]} ");
        }
    }
}
