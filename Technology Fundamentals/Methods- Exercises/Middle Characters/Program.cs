using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Characters
{
    public class Program
    {
        public static void Main()
        {
            PrintMiddleCharacters(Console.ReadLine());
        }

        public static void PrintMiddleCharacters(string input)
        {
            int toPrint = input.Length / 2;

            if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[toPrint]);
            }
            else
            {
                Console.WriteLine($"{input[toPrint - 1]}{input[toPrint]}");
            }
        }
    }
}
