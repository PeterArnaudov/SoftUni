using System;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            string result;

            if (number1 == number2 && number1 == number3 && number2 == number3)
                result = "yes";
            else
                result = "no";

            Console.WriteLine(result);
        }
    }
}
