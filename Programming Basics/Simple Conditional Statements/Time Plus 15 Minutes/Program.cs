using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Plus_15_Minutes
{
    class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes % 60 <= 14)
            {
                hours++; //hours += 1;
                minutes -= 60;
            }
            if (hours == 24)
                hours = 0;

            if (minutes < 10)
                Console.WriteLine("{0}:0{1}", hours, minutes);
            else
                Console.WriteLine("{0}:{1}", hours, minutes);
        }
    }
}
