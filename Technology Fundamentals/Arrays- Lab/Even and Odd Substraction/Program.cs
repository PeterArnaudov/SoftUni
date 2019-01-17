using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_Substraction
{
    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    evenSum += array[i];
                else
                    oddSum += array[i];
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
