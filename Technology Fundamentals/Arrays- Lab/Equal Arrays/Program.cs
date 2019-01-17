using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Arrays
{
    public class Program
    {
        public static void Main()
        {
            int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < Math.Min(arrayOne.Length, arrayTwo.Length); i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum += arrayOne[i];
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
