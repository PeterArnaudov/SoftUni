using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            var m1 = Console.ReadLine().ToLower(); //[read] metric
            var m2 = Console.ReadLine().ToLower(); //[write] metric

            // solution 1 (many ifs):
            if (m1 == "km")
                number /= 0.001;
            if (m1 == "mm")
                number /= 1000;
            if (m1 == "cm")
                number /= 100;
            if (m1 == "mi")
                number /= 0.000621371192;
            if (m1 == "in")
                number /= 39.3700787;
            if (m1 == "ft")
                number /= 3.2808399;
            if (m1 == "yd")
                number /= 1.0936133;


            if (m2 == "ft")
                number *= 3.2808399;
            if (m2 == "mm")
                number *= 1000;
            if (m2 == "cm")
                number *= 100;
            if (m2 == "mi")
                number *= 0.000621371192;
            if (m2 == "in")
                number *= 39.3700787;
            if (m2 == "km")
                number *= 0.001;
            if (m2 == "yd")
                number *= 1.0936133;

            Console.WriteLine(number);

            // solution 2 (switch-case):
            switch (m1)
            {
                case "km": number /= 0.001; break;
                case "mm": number /= 1000; break;
                case "cm": number /= 100; break;
                case "mi": number /= 0.000621371192; break;
                case "ft": number /= 3.2808399; break;
                case "in": number /= 39.3700787; break;
                case "yd": number /= 1.0936133; break;
            }

            switch (m2)
            {
                case "km": number *= 0.001; break;
                case "mm": number *= 1000; break;
                case "cm": number *= 100; break;
                case "mi": number *= 0.000621371192; break;
                case "ft": number *= 3.2808399; break;
                case "in": number *= 39.3700787; break;
                case "yd": number *= 1.0936133; break;
            }

            Console.WriteLine(number);
        }
    }
}
