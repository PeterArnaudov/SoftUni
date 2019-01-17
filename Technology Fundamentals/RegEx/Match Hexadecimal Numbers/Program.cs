using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Hexadecimal_Numbers
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string regex = @"\b(?:0x)?[0-9A-F]+\b";

            string[] numbers = Regex.Matches(input, regex).Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(" ", numbers));

            //string input = Console.ReadLine();

            //string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            //Regex regex = new Regex(pattern);

            //MatchCollection hexadecimalNumbersMatches = regex.Matches(input);

            //string[] hexadecimalNumbers = hexadecimalNumbersMatches.Cast<Match>().Select(x => x.Value).ToArray();

            //Console.WriteLine(string.Join(" ", hexadecimalNumbers));
        }
    }
}
