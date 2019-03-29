using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Integers
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                string number = Console.ReadLine();

                if (number == "END")
                {
                    break;
                }

                CheckIfPalindrome(number);
            }
        }

        public static void CheckIfPalindrome(string number)
        {
            string backwardsNumber = string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                backwardsNumber += number[i];
            }

            if (number == backwardsNumber)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
