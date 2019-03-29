using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    public class Program
    {
        public static void Main()
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\\', '/', '[', ']', ' ', (char)39 }; //(char)39 => '
            List<string> input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            for (int i = 0; i < input.Count(); i++)
            {
                bool lowerFound = false;
                bool upperFound = false;
                bool nonLetter = false;

                for (int j = 0; j < input[i].Length; j++)
                {
                    if (char.IsLower(input[i][j]))
                    {
                        lowerFound = true;
                    }
                    else if (char.IsUpper(input[i][j]))
                    {
                        upperFound = true;
                    }
                    else if (!char.IsLetter(input[i][j]))
                    {
                        nonLetter = true;
                    }
                }

                if (lowerFound && !upperFound && !nonLetter)
                {
                    lowerCaseWords.Add(input[i]);
                }
                else if (!lowerFound && upperFound && !nonLetter)
                {
                    upperCaseWords.Add(input[i]);
                }
                else
                {
                    mixedCaseWords.Add(input[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}