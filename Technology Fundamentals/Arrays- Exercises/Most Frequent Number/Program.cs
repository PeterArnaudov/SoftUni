using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int bestCounter = 0;
            int position = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        counter++;
                }

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    position = i;
                }

                counter = 0;
            }
            Console.WriteLine(array[position]);
        }
    }
}
