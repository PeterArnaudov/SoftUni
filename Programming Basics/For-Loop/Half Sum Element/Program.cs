using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > max)
                    max = number;

                sum += number;
            }

            sum -= max;

            if (max == sum)
                Console.WriteLine($"Yes Sum = {sum}");
            else
                Console.WriteLine($"No Diff = {Math.Abs(max - sum)}");
        }
    }
}
