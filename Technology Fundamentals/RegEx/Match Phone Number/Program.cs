using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\+359([\s|-])[2]\1[\d]{3}\1[\d]{4}\b";
            Regex regex = new Regex(pattern);

            MatchCollection matched = regex.Matches(input);

            string[] validNumbers = matched.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(", ", validNumbers));

            //List<string> numbers = new List<string>();

            //foreach (Match validNumber in validNumbers)
            //{
            //    numbers.Add(validNumber.Value);
            //}

            //Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
