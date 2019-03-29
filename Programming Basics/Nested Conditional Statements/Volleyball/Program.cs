using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main()
        {
            string yearType = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsInHomeTown = double.Parse(Console.ReadLine());

            int volleyballWeekends = 48;
            double weekendsInSofia = volleyballWeekends - weekendsInHomeTown;
            double volleyballInSofia = (weekendsInSofia * 3) / 4;
            double volleyballDuringHolidays = (holidays * 2) / 3;
            double totalPlayedDuringNormalYear = weekendsInHomeTown + volleyballInSofia + volleyballDuringHolidays;
            double totalPlayedDuringLeapYear = totalPlayedDuringNormalYear + (totalPlayedDuringNormalYear * 0.15);
            string exit = string.Empty;

            switch (yearType)
            {
                case "normal":
                    exit = $"{Math.Floor(totalPlayedDuringNormalYear)}"; break;
                case "leap":
                    exit = $"{Math.Floor(totalPlayedDuringLeapYear)}"; break;
            }

            Console.WriteLine(exit);

        }
    }
}
