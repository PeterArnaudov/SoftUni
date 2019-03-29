using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters_in_Range
{
    public class Program
    {
        public static void Main()
        {
            PrintCharactersInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }

        public static void PrintCharactersInRange(char start, char end)
        {
            if (start < end)
            {
                for (char i = ++start; i < end; i++)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                for (char i = ++end; i < start; i++)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
