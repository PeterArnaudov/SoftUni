using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Softuni_Coffee_Orders
{
    public class Program
    {
        public static void Main()
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;

            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                int days = DateTime.DaysInMonth(date.Year, date.Month);
                decimal price = (days * capsulesCount) * capsulePrice;
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
