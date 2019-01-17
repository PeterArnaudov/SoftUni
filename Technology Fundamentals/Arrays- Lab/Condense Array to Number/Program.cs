using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[array.Length - 1];

            if (array.Length != 1)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        condensed[i] = array[i] + array[i + 1];
                        array[i] = condensed[i];
                    }
                    for (int j = 0; j < condensed.Length; j++)
                    {
                        array[j] = condensed[j];
                    }
                }
                Console.WriteLine(condensed[0]);
            }
            else
            {
                Console.WriteLine(array[0]);
            }
        }
    }
}
