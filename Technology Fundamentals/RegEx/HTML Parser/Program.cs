using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HTML_Parser
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string titlePattern = @"<title>(.+)<\/title>";
            Match titleMatch = Regex.Match(input, titlePattern);

            string content = Regex.Replace(input, titleMatch.Groups[1].Value, "");
            content = Regex.Replace(content, @"<\s*[^>]*>", " ");
            content = Regex.Replace(content, @"\\n", "");
            content = Regex.Replace(content, @"\-?\d+\.?\d*", ""); // removes the numbers (negative, positive, floating point) as we need only the text
            content = Regex.Replace(content, @"\s{2,}", " ");

            Console.WriteLine($"Title: {titleMatch.Groups[1].Value}");
            Console.WriteLine($"Content:{content}");
        }
    }
}
