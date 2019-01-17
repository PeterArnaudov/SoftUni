using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_Trick
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> output = new List<int>();

            for (int i = 0; i < numbers.Count() / 2; i++)
            {
                output.Add(numbers[i] + numbers[numbers.Count() - 1 - i]);
            }
            
            if (numbers.Count() % 2 != 0)
            {
                output.Add(numbers[numbers.Count() / 2]);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
