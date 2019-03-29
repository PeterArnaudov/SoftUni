using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Wars
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            int maxSum = int.MinValue;
            string winner = string.Empty;

            while (name != "STOP")
            {
                int sum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    winner = name;
                }

                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winner} - {maxSum}!");
        }
    }
}
