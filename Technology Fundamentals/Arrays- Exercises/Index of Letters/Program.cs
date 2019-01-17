using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    public class Program
    {
        public static void Main()
        {
            char[] indexesLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] indexesNumbers = new int[indexesLetters.Length];

            for (int i = 0; i < indexesNumbers.Length; i++)
                indexesNumbers[i] = i;

            string input = Console.ReadLine();
            char[] letters = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
                letters[i] = input[i];

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < indexesLetters.Length; j++)
                {
                    if (letters[i] == indexesLetters[j])
                        Console.WriteLine($"{letters[i]} -> {indexesNumbers[j]}");
                }
            }
        }
    }
}
