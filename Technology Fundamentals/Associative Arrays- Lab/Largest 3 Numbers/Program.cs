using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(number => number).Take(3).ToList();

            //numbers = numbers.OrderByDescending(number => number).Take(3).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
