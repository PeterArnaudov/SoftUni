using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitute
{
    class Program
    {
        static void Main()
        {
            int startNumberOneOfOne = int.Parse(Console.ReadLine());
            int startNumberTwoOfOne = int.Parse(Console.ReadLine());
            int startNumberOneOfTwo = int.Parse(Console.ReadLine());
            int startNumberTwoOfTwo = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = startNumberOneOfOne; i <= 8; i++)
            {
                for (int j = 9; j >= startNumberTwoOfOne; j--)
                {
                    for (int k = startNumberOneOfTwo; k <= 8; k++)
                    {
                        for (int l = 9; l >= startNumberTwoOfTwo; l--)
                        {
                            if (i % 2 == 0 && k % 2 == 0 && j % 2 != 0 && l % 2 != 0)
                            {
                                if (i == k && j == l)
                                    Console.WriteLine("Cannot change the same player.");
                                else
                                {
                                    Console.WriteLine($"{i}{j} - {k}{l}");
                                    count++;
                                }

                                if (count == 6) return;
                            }
                        }
                    }
                }
            }
        }
    }
}
