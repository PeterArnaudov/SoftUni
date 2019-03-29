using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Even_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                    sum += array[i];

            Console.WriteLine(sum);
        }
    }
}
