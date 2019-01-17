using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip_to_World_Cup
{
    class Program
    {
        static void Main()
        {
            double goingPrice = double.Parse(Console.ReadLine());
            double backPrice = double.Parse(Console.ReadLine());
            double matchPrice = double.Parse(Console.ReadLine());
            int matchNumber = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine()) / 100;

            double moneyForTickets = 6 * (goingPrice + backPrice);
            double moneyForDiscountedTickets = moneyForTickets * (1 - discount);
            double moneyForMatches = 6 * matchNumber * matchPrice;
            double totalMoney = moneyForDiscountedTickets + moneyForMatches;
            double moneyPerPerson = totalMoney / 6;

            Console.WriteLine($"Total sum: {totalMoney:f2} lv.");
            Console.WriteLine($"Each friend has to pay {moneyPerPerson:f2} lv.");
        }
    }
}
