using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    public class Program
    {
        public static void Main()
        {
            char[] separators = new char[] { ' ', '.', '?', '!', ',' };
            string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 1)
                {
                    palindromes.Add(words[i]);
                }
                else if (words[i].Length % 2 == 0)
                {
                    int middle = words[i].Length / 2;

                    string left = words[i].Substring(0, middle);
                    string right = words[i].Substring(middle);

                    char[] rightChars = right.ToCharArray();

                    string rightReverse = string.Empty;

                    for (int j = right.Length - 1; j >= 0; j--)
                    {
                        rightReverse += rightChars[j];
                    }

                    if (left == rightReverse)
                    {
                        palindromes.Add(words[i]);
                    }
                }
                else
                {
                    int middle = words[i].Length / 2;

                    string left = words[i].Substring(0, middle + 1);
                    string right = words[i].Substring(middle);

                    char[] rightChars = right.ToCharArray();

                    string rightReverse = string.Empty;

                    for (int j = right.Length - 1; j >= 0; j--)
                    {
                        rightReverse += rightChars[j];
                    }

                    if (left == rightReverse)
                    {
                        palindromes.Add(words[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(x => x)));
        }
    }
}
