using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_from_100_to_200
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
                Console.WriteLine("Less than 100");
            else if (number >= 100 && number <= 200)
                Console.WriteLine("Between 100 and 200");
            else if (number > 200)
                Console.WriteLine("Greater than 200");
        }
    }
}
