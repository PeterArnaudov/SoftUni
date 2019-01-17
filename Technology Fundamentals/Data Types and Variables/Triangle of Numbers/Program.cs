using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                Console.Write(i);
                for (int j = 1; j < i; j++)
                {
                    Console.Write($" {i}");
                }
                Console.WriteLine();
            }
        }
    }
}
