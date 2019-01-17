using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Melrah_Shake
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            bool shake = true;

            while (shake && pattern.Length > 0)
            {
                int count = Regex.Matches(input, pattern).Count;

                if (count > 1)
                {
                    int index = input.IndexOf(pattern);
                    input = input.Remove(index, pattern.Length);

                    int lastIndex = input.LastIndexOf(pattern);
                    input = input.Remove(lastIndex, pattern.Length);
                }
                else
                {
                    break;
                }

                Console.WriteLine("Shaked it.");
                shake = true;

                int removeAt = pattern.Length / 2;
                pattern = pattern.Remove(removeAt, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
