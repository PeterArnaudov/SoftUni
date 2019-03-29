using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Key_Replacer
{
    public class Program
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            string pattern = @"([a-zA-Z]+)[<|\|\\].+[<|\|\\]([a-zA-Z]+)";
            Match keyMatch = Regex.Match(key, pattern);

            string start = keyMatch.Groups[1].Value;
            string end = keyMatch.Groups[2].Value;

            string keyPattern = $@"(?:{start})(.*?)(?:{end})";
            MatchCollection matches = Regex.Matches(input, keyPattern);

            string output = string.Empty;

            foreach (Match match in matches)
            {
                output += match.Groups[1].Value;
            }

            if (output.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}
