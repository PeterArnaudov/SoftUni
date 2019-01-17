using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    public class Program
    {
        public static void Main()
        {
            char[] array = GetDigits(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        public static char[] GetDigits(string number)
        {
            char[] array = new char[number.Length];
            int counter = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                array[i] = number[counter];
                counter++;
            }
            return array;
        }
    }
}
