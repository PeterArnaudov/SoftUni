using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            if (array.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (i > 0)
                        leftSum += array[j - 1];
                    else
                    {
                        leftSum = 0;
                        break;
                    }
                }
                for (int k = i; k < array.Length - 1; k++)
                {
                    rightSum += array[k + 1];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }
            Console.WriteLine("no");
        }
    }
}
