using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    public class Program
    {
        public static void Main()
        {
            double area = TriangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(area);
        }

        public static double TriangleArea(double side, double height)
        {
            return (side * height / 2);
        }
    }
}
