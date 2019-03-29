using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            var onLeftSide = (x == x1) && (y >= y1) && (y <= y2);
            var onRightSide = (x == x2) && (y >= y1) && (y <= 2);
            var onUpSide = (y == y1) && (x >= x1) && (x <= x2);
            var onDownSide = (y == y2) && (x >= x1) && (x <= x2);

            if (onLeftSide || onRightSide || onUpSide || onDownSide)
                Console.WriteLine("Border");
            else
                Console.WriteLine("Inside / Outside");
        }
    }
}
