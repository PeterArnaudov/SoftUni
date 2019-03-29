using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = array.Length / 4;
            int middle = array.Length / 2;
            int counter = 0;
            int[] firstRow = new int[array.Length];
            int[] secondRow = new int[array.Length];
            int[] sum = new int[array.Length];

            for (int i = k - 1; i >= 0; i--)
            {
                firstRow[counter] = array[i];
                counter++;
            }
            for (int i = array.Length - 1; i >= middle + k; i--)
            {
                firstRow[counter] = array[i];
                counter++;
            }
            counter = 0;
            for (int i = k; i < array.Length - k; i++)
            {
                secondRow[counter] = array[i];
                counter++;  
            }

            for (int i = 0; i < middle; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }

            for (int i = 0; i < middle; i++)
            {
                Console.Write($"{sum[i]} ");
            }
        }
    }
}
