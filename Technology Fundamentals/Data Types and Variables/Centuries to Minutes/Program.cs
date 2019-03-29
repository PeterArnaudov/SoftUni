using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            double days = years * 365.2422;
            int hours = (int)days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes");
        }
    }
}
