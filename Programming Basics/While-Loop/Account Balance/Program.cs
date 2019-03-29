using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Balance
{
    class Program
    {
        static void Main()
        {
            int incomes = int.Parse(Console.ReadLine());
            double increase = 0.0;
            double balance = 0.0;

            while (incomes != 0)
            {
                increase = double.Parse(Console.ReadLine());

                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine("Your account balance was increased by: {0:f2}", increase);
                balance += increase;
                incomes--;
            }

            Console.WriteLine("Total balance: {0:f2}", balance);
        }
    }
}
