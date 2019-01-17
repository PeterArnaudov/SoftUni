using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders__Dictionaries_
{
    public class Program
    {
        public static void Main()
        {
            //Dictionary<string, Dictionary<int, double>> products = new Dictionary<string, Dictionary<int, double>>();
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            Dictionary<string, int> productsQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] order = Console.ReadLine().Split();

                if (order[0] == "buy")
                {
                    break;
                }

                string product = order[0];
                double price = double.Parse(order[1]);
                int quantity = int.Parse(order[2]);

                if (!productsPrice.ContainsKey(product))
                {
                    productsPrice.Add(product, price);
                    productsQuantity.Add(product, quantity);
                }
                else
                {
                    productsPrice[product] = price;
                    productsQuantity[product] += quantity;
                }
            }

            foreach (var item in productsPrice)
            {
                Console.WriteLine($"{item.Key} -> {item.Value * productsQuantity[item.Key]:f2}");
            }
        }
    }
}
