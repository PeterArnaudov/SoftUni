using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    class Program
    {
        static void Main()
        {
            int initialPassengers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());
            int passengers = 0;

            for (int i = 1; i <= stops; i++)
            {
                int passengersOut = int.Parse(Console.ReadLine());
                int passengersIn = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                    passengersIn += 2;
                else if (i % 2 == 0)
                    passengersOut += 2;

                passengers += passengersIn - passengersOut;
            }

            passengers += initialPassengers;
            Console.WriteLine($"The final number of passengers is : {passengers}");
        }
    }
}
