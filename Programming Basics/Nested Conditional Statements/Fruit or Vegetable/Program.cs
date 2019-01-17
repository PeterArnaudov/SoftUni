using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();

            bool fruit = product == "banana" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes" || product == "apple";
            bool vegetable = product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot";

            string exit = string.Empty;

            if (fruit)
                exit = "fruit";
            else if (vegetable)
                exit = "vegetable";
            else
                exit = "unknown";

            Console.WriteLine(exit);
        }
    }
}
