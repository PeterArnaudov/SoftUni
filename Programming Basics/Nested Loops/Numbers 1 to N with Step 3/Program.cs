using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_1_to_N_with_Step_3
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
