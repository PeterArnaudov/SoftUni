using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    public class Program
    {
        public static void Main()
        {
            char[] arrayOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arrayTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Min(arrayOne.Length - 1, arrayTwo.Length - 1); i++)
            {
                if (arrayOne[i] < arrayTwo[i])
                {
                    for (int j = 0; j < arrayOne.Length; j++)
                        Console.Write($"{arrayOne[j]}");
                    Console.WriteLine();
                    for (int k = 0; k < arrayTwo.Length; k++)
                        Console.Write($"{arrayTwo[k]}");
                    return;
                }
                else if (arrayOne[i] > arrayTwo[i])
                {
                    {
                        for (int k = 0; k < arrayTwo.Length; k++)
                            Console.Write($"{arrayTwo[k]}");
                        Console.WriteLine();
                        for (int j = 0; j < arrayOne.Length; j++)
                            Console.Write($"{arrayOne[j]}");
                    }
                    return;
                }
                else
                    continue;
            }

            if (arrayOne.Length > arrayTwo.Length)
            {
                for (int k = 0; k < arrayTwo.Length; k++)
                    Console.Write($"{arrayTwo[k]}");
                Console.WriteLine();
                for (int j = 0; j < arrayOne.Length; j++)
                    Console.Write($"{arrayOne[j]}");
            }
            else
            {
                for (int k = 0; k < arrayOne.Length; k++)
                    Console.Write($"{arrayOne[k]}");
                Console.WriteLine();
                for (int j = 0; j < arrayTwo.Length; j++)
                    Console.Write($"{arrayTwo[j]}");
            }
        }
    }
}
