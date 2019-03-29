using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int arrayOneSize = arrayOne.Length;
            int arrayTwoSize = arrayTwo.Length;
            int counter = 0;

            if (arrayOneSize == arrayTwoSize)
            {
                for (int i = 0; i < arrayOneSize; i++)
                    Console.Write($"{arrayOne[i] + arrayTwo[i]} ");
            }
            else if (arrayOneSize > arrayTwoSize)
            {
                for (int j = 0; j < arrayOneSize; j++)
                {
                    if (counter >= arrayTwoSize)
                        counter = 0;
                    Console.Write($"{arrayOne[j] + arrayTwo[counter]} ");
                    counter++;
                }
            }
            else if (arrayTwoSize > arrayOneSize)
            {
                for (int k = 0; k < arrayTwoSize; k++)
                {
                    if (counter >= arrayOneSize)
                        counter = 0;
                    Console.Write($"{arrayOne[counter] + arrayTwo[k]} ");
                    counter++;
                }
            }
        }
    }
}
