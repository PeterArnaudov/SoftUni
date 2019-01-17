using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Chars_in_a_String
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<char, int> charsInString = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!charsInString.ContainsKey(input[i]))
                {
                    if (input[i] == ' ')
                    {
                        continue;
                    }
                    charsInString.Add(input[i], 1);
                }
                else
                {
                    charsInString[input[i]]++;
                }
            }

            foreach (var character in charsInString)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
