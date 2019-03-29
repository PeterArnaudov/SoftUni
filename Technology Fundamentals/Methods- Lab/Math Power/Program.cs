using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    public class Program
    {
        public static void Main()
        {
            double poweredNumber = MathPower(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(poweredNumber);
        }

        public static double MathPower(double number, double power)
        {
            return (Math.Pow(number, power));
        }
    }
}
