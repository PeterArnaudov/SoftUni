using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main()
        {
            string destination = Console.ReadLine();
            if (destination == "End") return;
            double moneyNeeded = double.Parse(Console.ReadLine());
            double savedMoney = 0;
            double money = 0;

            while (true)
            {
                money = double.Parse(Console.ReadLine());
                savedMoney += money;

                if (savedMoney >= moneyNeeded)
                {
                    Console.WriteLine($"Going to {destination}!");
                    destination = Console.ReadLine();
                    if (destination == "End") return;
                    moneyNeeded = double.Parse(Console.ReadLine());
                    savedMoney = 0;
                }
            }
        }
    }
}
