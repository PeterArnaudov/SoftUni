using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=\s)[a-zA-Z0-9]+([-_.]*[a-zA-Z0-9]+)+@[a-zA-Z]+\-*[a-zA-Z]+(\.{1}[a-zA-Z]+\-*[a-zA-Z])+";

            Regex regex = new Regex(pattern);

            MatchCollection emails = regex.Matches(input);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
