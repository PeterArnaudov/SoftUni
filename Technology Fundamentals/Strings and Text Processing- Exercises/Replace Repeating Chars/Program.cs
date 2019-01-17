using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Repeating_Chars
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string result = string.Empty;
            char past = '$';
            bool same = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != past)
                {
                    past = input[i];
                    same = false;
                }
                else
                {
                    same = true;
                }

                if (!same)
                {
                    result += past;
                }
            }

            Console.WriteLine(result);
        }
    }
}
