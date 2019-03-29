using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > max)
                    max = number;
            }

            Console.WriteLine(max);
        }
    }
}
