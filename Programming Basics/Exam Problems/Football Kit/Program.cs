using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Kit
{
    class Program
    {
        static void Main()
        {
            double tshirt = double.Parse(Console.ReadLine());
            double goal = double.Parse(Console.ReadLine());

            double shorts = tshirt * 0.75;
            double socks = shorts * 0.2;
            double shoes = 2 * (tshirt + shorts);

            double total = (tshirt + shorts + socks + shoes) * 0.85;

            if (total >= goal)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"No, he will not earn the world-cup replica ball!");
                Console.WriteLine($"He needs {goal - total:f2} lv. more");
            }
        }
    }
}
