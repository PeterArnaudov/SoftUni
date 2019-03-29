namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public double Money
        {
            get
            {
                return this.money;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (this.money < product.Cost)
            {
                Console.WriteLine($"{this.name} can't afford {product.Name}");
            }
            else
            {
                this.money -= product.Cost;
                Console.WriteLine($"{this.name} bought {product.Name}");
                bag.Add(product);
            }
        }

        public void PrintGroceries()
        {
            if (this.bag.Count == 0)
            {
                Console.WriteLine($"{this.name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{this.Name} - {string.Join(", ", bag.Select(p => p.Name))}");
            }
        }
    }
}
