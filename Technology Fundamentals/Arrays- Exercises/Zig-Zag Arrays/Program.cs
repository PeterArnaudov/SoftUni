using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zig_Zag_Arrays
{
    public class Program
    {
        public static void Main()
        {
            int pairs = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[pairs];
            int[] arrayTwo = new int[pairs];
            int[] input = new int[2];

            for (int i = 1; i <= pairs; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    arrayOne[i - 1] = input[0];
                    arrayTwo[i - 1] = input[1];
                }
                else
                {
                    arrayOne[i - 1] = input[1];
                    arrayTwo[i - 1] = input[0];
                }

                input[0] = 0;
                input[1] = 0;
            }

            foreach (int number in arrayOne)
                Console.Write(number + " ");

            Console.WriteLine();

            foreach (int number in arrayTwo)
                Console.Write(number + " ");
        }
    }
}
