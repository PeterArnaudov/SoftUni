using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    public class Program
    {
        public static void Main()
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
                Console.WriteLine(daysOfWeek[day - 1]);
            else
                Console.WriteLine("Invalid day!");
        }
    }
}
