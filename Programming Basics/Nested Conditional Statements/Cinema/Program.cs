using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main()
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 1;
            int places = rows * columns;

            switch (projectionType) //this problem can be solved with if-else too
            {
                case "Premiere":
                    price = 12; break;
                case "Normal":
                    price = 7.5; break;
                case "Discount":
                    price = 5; break;
            }

            double profit = places * price;
            Console.WriteLine($"{profit:f2}");
        }
    }
}
