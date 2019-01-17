using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int leftNumber = int.Parse(Console.ReadLine());

                leftSum += leftNumber;
            }

            for (int i = 0; i < numbersCount; i++)
            {
                int rightNumber = int.Parse(Console.ReadLine());

                rightSum += rightNumber;
            }

            if (leftSum == rightSum)
                Console.WriteLine($"Yes, sum = {leftSum}");
            else
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}
