using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    public class Program
    {
        public static void Main()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] - ((int)array[i]) == 0.5)
                    Console.WriteLine($"{array[i]} => {Math.Ceiling(array[i])}");
                else if (array[i] - ((int)array[i]) == -0.5)
                    Console.WriteLine($"{array[i]} => {Math.Floor(array[i])}");
                else
                    Console.WriteLine($"{array[i]} => {Math.Round(array[i])}");
            }
        }
    }
}
