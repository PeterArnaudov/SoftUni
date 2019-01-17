using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sino_The_Walker
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            DateTime departureTime = DateTime.ParseExact(input, "HH:mm:ss", CultureInfo.InvariantCulture);

            int steps = int.Parse(Console.ReadLine()) % 86400; //using % 86400 to remove inputs consisting of whole days
            int timePerStep = int.Parse(Console.ReadLine()) % 86400;

            int travelTime = steps * timePerStep;

            DateTime arrivalTime = departureTime.AddSeconds(travelTime);

            Console.WriteLine($"Time Arrival: {arrivalTime.ToString("HH:mm:ss")}");
        }
    }
}
