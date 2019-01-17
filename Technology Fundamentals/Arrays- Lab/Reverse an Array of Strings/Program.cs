using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Strings
{
    public class Program
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Split(' ');

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"array[{i}] = {array[i]}");
            //} <-- провери всеки индекс какво съдържа

            foreach (var item in array.Reverse())
                Console.Write(item + " ");

            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{array[i]} ");
            //} <-- алтернативно решение
        }
    }
}
