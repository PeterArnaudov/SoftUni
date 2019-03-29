using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Count
{
    public class Program
    {
        public static void Main()
        {
            PrintVowelsCount(Console.ReadLine().ToLower());
        }

        public static void PrintVowelsCount(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
