using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    public class Program
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int i = 0;

            while (i < numbers.Count() - 1)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i + 1] += numbers[i];
                    numbers.RemoveAt(i);
                    i--;

                    if (i < 0)
                    {
                        i = 0;
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}