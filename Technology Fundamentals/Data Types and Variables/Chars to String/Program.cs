using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chars_to_String
{
    public class Program
    {
        public static void Main()
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());
            char charThree = char.Parse(Console.ReadLine());

            string output = $"{charOne}{charTwo}{charThree}";

            Console.WriteLine(output);
        }
    }
}
