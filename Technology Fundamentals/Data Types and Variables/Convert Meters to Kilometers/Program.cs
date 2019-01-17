using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Meters_to_Kilometers
{
    public class Program
    {
        public static void Main()
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
