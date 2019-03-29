namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] peopleInfoPairs = Console.ReadLine().Split(';', '=');
            string[] productsInfoPairs = Console.ReadLine().Split(';', '=');

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                for (int i = 0; i < peopleInfoPairs.Length; i += 2)
                {
                    people.Add(new Person(peopleInfoPairs[i], double.Parse(peopleInfoPairs[i + 1])));
                }

                for (int i = 0; i < productsInfoPairs.Length; i += 2)
                {
                    if (string.IsNullOrEmpty(productsInfoPairs[i]))
                    {
                        break;
                    }

                    products.Add(new Product(productsInfoPairs[i], double.Parse(productsInfoPairs[i + 1])));
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }

                people.FirstOrDefault(p => p.Name == command[0]).BuyProduct(products.FirstOrDefault(p => p.Name == command[1]));
            }

            people.ForEach(p => p.PrintGroceries());
        }
    }
}
