using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Working_Days
{
    public class Program
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            //DateTime[] holidays = new DateTime[11];
            //holidays[0] = DateTime.ParseExact("01-01", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[1] = DateTime.ParseExact("03-03", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[2] = DateTime.ParseExact("01-05", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[3] = DateTime.ParseExact("06-05", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[4] = DateTime.ParseExact("24-05", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[5] = DateTime.ParseExact("06-09", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[6] = DateTime.ParseExact("22-09", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[7] = DateTime.ParseExact("01-11", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[8] = DateTime.ParseExact("24-12", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[9] = DateTime.ParseExact("25-12", "dd-MM", CultureInfo.InvariantCulture);
            //holidays[10] = DateTime.ParseExact("26-12", "dd-MM", CultureInfo.InvariantCulture);

            string[] holidays = {"1-1", "3-3", "1-5", "6-5", "24-5", "6-9", "22-9", "1-11", "24-12", "25-12", "26-12"};

            int workingDays = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                bool weekend = i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday;

                if (!weekend && !holidays.Contains($"{i.Day}-{i.Month}"))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
