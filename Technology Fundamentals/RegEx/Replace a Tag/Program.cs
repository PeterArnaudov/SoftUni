using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Replace_a_Tag
{
    public class Program
    {
        public static void Main()
        {
            List<string> inputList = new List<string>();
            string pattern = @"<a.*?href=("".+?"")>(.+?)<\/a>";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                inputList.Add(input);
            }

            foreach (var line in inputList)
            {
                Match match = Regex.Match(line, pattern);

                if (match.Value.Length > 0)
                {
                    string replacement = @"[URL href=$1]$2[/URL]";
                    string replaced = Regex.Replace(line, pattern, replacement);
                    Console.WriteLine(replaced);
                }
                else
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
