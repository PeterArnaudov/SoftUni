using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area__Precision_12_
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"{radius * radius * Math.PI:f12}");
        }
    }
}
