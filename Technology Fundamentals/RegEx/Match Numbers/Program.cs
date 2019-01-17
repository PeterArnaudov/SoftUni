using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Match_Numbers
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"^-?\d+\.?(\d+)?($|(?=\s))";
            //(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))  => use that if not separating the input into array of strings

            foreach (var token in input)
            {
                Match number = Regex.Match(token, pattern);

                if (number.Value.Length > 0)
                {
                    Console.Write(number.Value + " ");
                }
            }
        }
    }
}
