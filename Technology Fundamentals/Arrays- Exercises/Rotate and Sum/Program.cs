using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main()
        {
            //First Solution:
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotates = int.Parse(Console.ReadLine());

            int[] sum = new int[array.Length];
            int[] rotated = new int[array.Length];

            for (int i = 0; i < rotates; i++)
            {
                for (int shifts = 0; shifts < array.Length; shifts++)
                {
                    if (shifts == 0)
                        rotated[0] = array[array.Length - 1];
                    else
                        rotated[shifts] = array[shifts - 1];
                }

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += rotated[j];
                }

                rotated.CopyTo(array, 0);                    
            }

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }

            // Second Solution:
            //int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int rotates = int.Parse(Console.ReadLine());

            //int[] sum = new int[array.Length];

            //for (int rotationsCount = 0; rotationsCount < rotates; rotationsCount++)
            //{
            //    int lastElement = array.Last();

            //    for (int shifts = array.Length - 1; shifts > 0; shifts--)
            //    {
            //        array[shifts] = array[shifts - 1];
            //    }

            //    array[0] = lastElement;

            //    for (int i = 0; i < sum.Length; i++)
            //    {
            //        sum[i] += array[i];
            //    }
            //}

            //for (int i = 0; i < sum.Length; i++)
            //{
            //    Console.Write($"{sum[i]} ");
            //}
        }
    }
}
