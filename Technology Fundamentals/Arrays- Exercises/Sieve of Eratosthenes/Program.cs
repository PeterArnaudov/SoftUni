using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    public class Program
    {
        public static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            bool[] prime = new bool[numbers + 1];

            for (int i = 0; i <= numbers; i++)
                prime[i] = true;

            for (int i = 2; i * i <= numbers; i++)
            {
                if (prime[i] == true)
                {
                    for (int j = i * 2; j <= numbers; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }

            for (int i = 2; i <= numbers; i++)
            {
                if (prime[i])
                    Console.Write($"{i} ");
            }
        }
    }
}
