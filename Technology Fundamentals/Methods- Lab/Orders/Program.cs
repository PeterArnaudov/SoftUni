using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class Program
    {
        public static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintPrice(product, quantity);
        }

        public static void PrintPrice(string product, int quantity)
        {
            double totalPrice = 0.0;

            switch (product)
            {
                case "coffee":
                    totalPrice = quantity * 1.5;
                    break;
                case "water":
                    totalPrice = quantity;
                    break;
                case "coke":
                    totalPrice = quantity * 1.4;
                    break;
                case "snacks":
                    totalPrice = quantity * 2;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
