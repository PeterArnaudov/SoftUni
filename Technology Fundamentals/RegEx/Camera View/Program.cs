using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Camera_View
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            int skip = numbers[0];
            int take = numbers[1];

            string pattern = @"\|<(\w{"+skip+@"})(\w{0,"+take+"})";
            MatchCollection matched = Regex.Matches(input, pattern);

            List<string> matches = new List<string>();

            foreach (Match match in matched)
            {
                matches.Add(match.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
