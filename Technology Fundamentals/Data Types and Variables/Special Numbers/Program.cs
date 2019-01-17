
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int maxNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maxNumber; i++)
            {
                if (i % 10 + i / 10 == 5 || i % 10 + i / 10 == 7 || i % 10 + i / 10 == 11)
                    Console.WriteLine($"{i} -> True");
                else
                    Console.WriteLine($"{i} -> False");
            }
        }
    }
}
