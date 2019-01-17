using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lower_or_Upper
{
    public class Program
    {
        public static void Main()
        {
            char character = char.Parse(Console.ReadLine());

            if (character >= 'a' && character <= 'z')
                Console.WriteLine("lower-case");
            else if (character >= 'A' && character <= 'Z')
                Console.WriteLine("upper-case");
        }
    }
}
