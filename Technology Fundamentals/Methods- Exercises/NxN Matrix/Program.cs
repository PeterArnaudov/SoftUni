using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxN_Matrix
{
    public class Program
    {
        public static void Main()
        {
            PrintMatrix(int.Parse(Console.ReadLine()));
        }

        public static void PrintMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
