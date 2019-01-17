using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"^[a-zA-Z][\w]{2,24}$";

            List<string> validUsernames = new List<string>();

            foreach (var line in input)
            {
                Match valid = Regex.Match(line, pattern);

                if (valid.Value.Length > 0)
                {
                    validUsernames.Add(valid.Value);
                }
            }

            int bestLength = 0;
            string[] output = new string[2];

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                int currentLength = validUsernames[i].Length + validUsernames[i + 1].Length;

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    output[0] = validUsernames[i];
                    output[1] = validUsernames[i + 1];
                }
            }

            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
        }
    }
}
