using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    counter++;
                    Console.Write($"{counter} ");
                    if (counter == number)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
