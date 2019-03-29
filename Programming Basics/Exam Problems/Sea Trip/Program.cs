using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Trip
{
    class Program
    {
        static void Main()
        {
            double moneyForFoodPerDay = double.Parse(Console.ReadLine());
            double moneyForSouvenirsPerDay = double.Parse(Console.ReadLine());
            double moneyForHotelPerDay = double.Parse(Console.ReadLine());

            double totalMoneyForHotel = moneyForHotelPerDay * 0.9 + moneyForHotelPerDay * 0.85 + moneyForHotelPerDay * 0.8;
            double totalMoneyForFood = moneyForFoodPerDay * 3;
            double totalMoneyForSouvenirs = moneyForSouvenirsPerDay * 3;
            double moneyForFuel = 54.39;

            double totalMoney = totalMoneyForHotel + totalMoneyForFood + totalMoneyForSouvenirs + moneyForFuel;
            Console.WriteLine($"Money needed: {totalMoney:f2}");
        }
    }
}
