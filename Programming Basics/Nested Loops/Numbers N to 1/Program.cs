using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_N_to_1
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = N; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
