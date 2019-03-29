using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (Math.Sqrt(numbers[i]) % 1 == 0)
                {
                    squareNumbers.Add(numbers[i]);
                }
            }

            squareNumbers.Sort();
            squareNumbers.Reverse();
            //squareNumbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
