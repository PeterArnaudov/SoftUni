using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Softuni_Bar_Income
{
    public class Program
    {
        public static void Main()
        {
            string validCustomerPattern = @"%([A-Z][a-z]+)%";
            string validProductPattern = @"<(\w+)>";
            string validCountPattern = @"\|(\d+)\|";
            string validPricePattern = @"(\d+\.?\d*)\$";

            List<Customer> customers = new List<Customer>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }

                Match validCustomer = Regex.Match(input, validCustomerPattern);
                Match validProduct = Regex.Match(input, validProductPattern);
                Match validCount = Regex.Match(input, validCountPattern);
                Match validPrice = Regex.Match(input, validPricePattern);

                if (validCustomer.Value.Length > 0 && validProduct.Value.Length > 0 && validCount.Value.Length > 0 && validPrice.Value.Length > 0)
                {
                    string name = validCustomer.Groups[1].Value;
                    string product = validProduct.Groups[1].Value;
                    double price = int.Parse(validCount.Groups[1].Value) * double.Parse(validPrice.Groups[1].Value);

                    customers.Add(new Customer(name, product, price));
                }
            }

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Name}: {customer.Product} - {customer.Bill:f2}");
            }
            Console.WriteLine($"Total income: {customers.Sum(x => x.Bill):f2}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public double Bill { get; set; }

        public Customer(string name, string product, double bill)
        {
            Name = name;
            Product = product;
            Bill = bill;
        }
    }
}
