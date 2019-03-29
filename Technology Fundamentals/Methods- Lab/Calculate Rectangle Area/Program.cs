using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Rectangle_Area
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(CalculateRectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
        }

        public static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
