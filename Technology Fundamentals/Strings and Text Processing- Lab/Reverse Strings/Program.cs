using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Strings
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string inputReversed = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    inputReversed += input[i];
                }

                Console.WriteLine($"{input} = {inputReversed}");
            }
        }
    }
}
