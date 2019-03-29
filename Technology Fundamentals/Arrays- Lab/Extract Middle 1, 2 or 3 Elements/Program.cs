using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = numbers.Length;
            
            if (count == 1)
                Console.WriteLine("{ " + numbers[0] + " }");
            else if (count % 2 == 0)
            {
                count = count / 2;
                Console.WriteLine("{ " + numbers[count - 1] + ", " + numbers[count] + " }");
            }
            else
            {
                count = count / 2;
                Console.WriteLine("{ " + numbers[count - 1] + ", " + numbers[count] + ", " + numbers[count + 1] + " }");
            }
        }
    }
}
