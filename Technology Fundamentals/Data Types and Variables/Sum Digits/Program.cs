using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine(sum);

            //string numberAsString = Console.ReadLine();
            //int sum = 0;

            //for (int i = 0; i < numberAsString.Length; i++)
            //{
            //    int digit = int.Parse(numberAsString[i].ToString());
            //    sum += digit;
            //}

            //Console.WriteLine(sum);
        }
    }
}
