using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main()
        {
            string wordNumberOne = Console.ReadLine().ToLower();
            string wordNumberTwo = Console.ReadLine().ToLower();

            if (wordNumberOne == wordNumberTwo)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
