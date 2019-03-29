using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int min = int.MaxValue;

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < min)
                    min = number;
            }

            Console.WriteLine(min);
        }
    }
}
