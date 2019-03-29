using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    public class Program
    {
        public static void Main()
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> townSales = new SortedDictionary<string, double>();

            for (int i = 0; i < numberOfSales; i++)
            {
                string[] input = Console.ReadLine().Split();

                Sale sale = ReadSale(input);

                if (!townSales.ContainsKey(sale.Town))
                {
                    townSales.Add(sale.Town, sale.Price * sale.Quantity);
                }
                else
                {
                    townSales[sale.Town] += sale.Price * sale.Quantity;
                }
            }

            foreach (var town in townSales)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }

        public static Sale ReadSale(string[] sale)
        {
            return new Sale
            {
                Town = sale[0],
                Product = sale[1],
                Price = double.Parse(sale[2]),
                Quantity = double.Parse(sale[3])
            };
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}
