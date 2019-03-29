using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    public class Program
    {
        public static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return ((fahrenheit - 32) * 5 / 9);
        }
    }
}
