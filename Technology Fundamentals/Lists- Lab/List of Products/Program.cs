using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Products
{
    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
