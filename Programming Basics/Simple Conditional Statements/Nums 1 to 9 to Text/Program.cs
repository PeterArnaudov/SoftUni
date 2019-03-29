using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nums_1_to_9_to_Text
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string numberToText = string.Empty;

            if (number == 1)
                numberToText = "one";
            else if (number == 2)
                numberToText = "two";
            else if (number == 3)
                numberToText = "three";
            else if (number == 4)
                numberToText = "four";
            else if (number == 5)
                numberToText = "five";
            else if (number == 6)
                numberToText = "six";
            else if (number == 7)
                numberToText = "seven";
            else if (number == 8)
                numberToText = "eight";
            else if (number == 9)
                numberToText = "nine";
            else
                numberToText = "number too big";

            Console.WriteLine(numberToText);
        }
    }
}
