using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);

            MatchCollection validNames = regex.Matches(input);

            foreach (Match name in validNames)
            {
                Console.Write($"{name.Value} ");
            }

            Console.WriteLine();
        }
    }
}
