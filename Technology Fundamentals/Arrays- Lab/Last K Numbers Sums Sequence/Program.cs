using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main()
        {
            long numberOfElements = long.Parse(Console.ReadLine());
            long sumLastElements = long.Parse(Console.ReadLine());

            long[] sequence = new long[numberOfElements];
            sequence[0] = 1;

            for (long i = 0; i < numberOfElements; i++)
            {
                long sum = 0;

                if (i <= sumLastElements)
                {
                    for (long j = i; j >= 0; j--)
                    {
                        sum += sequence[j];
                    }
                    sequence[i] = sum;
                }
                else
                {
                    for (long k = i - 1; k > i - sumLastElements - 1; k--)
                    {
                        sum += sequence[k];
                    }
                    sequence[i] = sum;
                }
            }

            for (long output = 0; output < numberOfElements; output++)
            {
                Console.Write($"{sequence[output]} ");
            }
        }
    }
}
