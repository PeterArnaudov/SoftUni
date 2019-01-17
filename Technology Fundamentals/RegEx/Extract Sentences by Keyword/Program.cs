using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extract_Sentences_by_Keyword
{
    public class Program
    {
        public static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = $@"\b[^?.!]*\b{keyword}\b[^!.?]*";

            MatchCollection matched = Regex.Matches(text, pattern);

            string[] sentences = matched.Cast<Match>().Select(s => s.Value).ToArray();

            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
