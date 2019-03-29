using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits__Letters_and_Other
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string letters = string.Empty;
            string digits = string.Empty;
            string others = string.Empty;

            foreach (var character in input)
            {
                if (char.IsLetter(character))
                {
                    letters += character;
                }
                else if (char.IsDigit(character))
                {
                    digits += character;
                }
                else
                {
                    others += character;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
