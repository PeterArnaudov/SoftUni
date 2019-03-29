using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min__Max__Sum__Average
{
    public class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers.Add(input);
            }

                    //Solution with Array:
            //int[] numbers = new int[count];

            //for (int i = 0; i < count; i++)
            //{
            //    int input = int.Parse(Console.ReadLine());
            //    numbers[i] = input;
            //}

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
