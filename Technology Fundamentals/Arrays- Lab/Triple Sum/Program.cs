using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //    Console.WriteLine("arr[{0}] = {1}", i, array[i]);
            //    Console.WriteLine($"array[{i}] = {array[i]}");
            //}

            bool requirment = false;

            for (int a = 0; a < array.Length; a++)
            {
                for (int b = a + 1; b < array.Length; b++)
                {
                    for (int c = 0; c < array.Length; c++)
                    {
                        if (array[a] + array[b] == array[c])
                        {
                            Console.WriteLine($"{array[a]} + {array[b]} == {array[c]}");
                            requirment = true;
                            break;
                        }
                    }
                }
            }
            if (requirment == false)
            {
                Console.WriteLine("No");
            }

        }
    }
}
