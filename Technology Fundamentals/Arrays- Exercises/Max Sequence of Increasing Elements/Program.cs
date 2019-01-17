using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int length = 1;
            int start = 0;
            int bestLength = 1;
            int bestStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                    length++;
                else
                {
                    length = 1;
                    start = i;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }

            }

            for (int i = bestStart; i < bestLength + bestStart; i++)
                Console.Write($"{array[i]} ");
        }
    }
}
