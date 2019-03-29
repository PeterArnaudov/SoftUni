using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintBorders(number);
            for (int i = 0; i < number - 2; i++)
                PrintBody(number);
            PrintBorders(number);
        }

        public static void PrintBorders(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        public static void PrintBody(int number)
        {
            Console.Write('-');
            for (int i = 1; i < number; i++)
                Console.Write("\\/");
            Console.WriteLine('-');
        }
    }
}
