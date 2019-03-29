using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int j = number - 1; j >= 0; j--)
            {   
                Console.Write($"{numbers[j]} ");
            }
        }
    }
}
