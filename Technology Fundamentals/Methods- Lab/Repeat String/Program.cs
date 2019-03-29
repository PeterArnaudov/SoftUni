using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_String
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(RepeatString(Console.ReadLine(), int.Parse(Console.ReadLine())));
        }

        public static string RepeatString(string input, int times)
        {
            string result = string.Empty;

            for (int i = 0; i < times; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
