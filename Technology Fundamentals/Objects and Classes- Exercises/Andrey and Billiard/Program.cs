using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrey_and_Billiard
{
    public class Program
    {
        public static void Main()
        {
            int numberOfEntities = int.Parse(Console.ReadLine());
            Dictionary<string, double> products = new Dictionary<string, double>();
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < numberOfEntities; i++) //enter products in the shop and their prices
            {
                string[] entity = Console.ReadLine().Split('-');
                string product = entity[0];
                double price = double.Parse(entity[1]);


                if (!products.ContainsKey(product))
                {
                    products.Add(product, 0);
                }

                products[product] = price;
            }

            while (true) //enter all customers and their groceries
            {
                string[] information = Console.ReadLine().Split('-', ',');

                if (information[0] == "end of clients") //stop if there are no more customers
                {
                    break;
                }

                string product = information[1];

                if (!products.ContainsKey(product)) //ignore if customer wants a non-existing product
                {
                    continue;
                }

                Customer newCustomer = ReadCustomer(information); //create a new customer object

                if (!customers.Any(x => x.Name == newCustomer.Name)) //if there is no already existing customer with that name - add it
                {
                    customers.Add(newCustomer);
                }
                else //if there is already customer with that name - add only the groceries to that customer's shop receipt
                {
                    var productToAdd = newCustomer.ShopList;

                    foreach (var customer in customers)
                    {
                        if (customer.Name == newCustomer.Name)
                        {
                            customer.AddProduct(newCustomer.ShopList);
                            break;
                        }
                    }
                }
            }

            foreach (var customer in customers) //calculate everyone's bill
            {
                foreach (var product in customer.ShopList)
                {
                    customer.Bill += product.Value * products[product.Key];
                }
            }

            double totalBill = 0.0;

            foreach (var customer in customers.OrderBy(x => x.Name)) //print the customer's name, bought groceries and bill
            {
                Console.WriteLine(customer.Name);

                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:f2}");
                totalBill += customer.Bill; //add each bill to the total bill
            }
            Console.WriteLine($"Total bill: {totalBill:f2}"); //print the total bill

        } //end of Main

        public static Customer ReadCustomer(string[] information) //create new customer object - method
        {
            string customer = information[0];
            Dictionary<string, int> bought = new Dictionary<string, int>();
            bought.Add(information[1], int.Parse(information[2]));

            return new Customer
            {
                Name = customer,
                ShopList = bought,
            };
        } //end of method
    } //end of class Program

    public class Customer //beginning of class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public double Bill { get; set; }

        public void AddProduct(Dictionary<string, int> productToAdd) //add products to the customer's ShopList
        {
            string productName = productToAdd.ElementAt(0).Key;
            int quantity = productToAdd.ElementAt(0).Value;
            if (!ShopList.ContainsKey(productName)) //if the product doesn't exist in the ShopList- add it with its quantity
            {
                ShopList.Add(productName, quantity);
            }
            else //if the product already exists in the ShopList- add to its quantity
            {
                ShopList[productName] += quantity;
            }
        }
    } //end of class Customer   
} //end