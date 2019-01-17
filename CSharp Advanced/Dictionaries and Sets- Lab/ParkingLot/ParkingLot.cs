namespace ParkingLot
{
    using System;
    using System.Collections.Generic;

    public class ParkingLot
    {
        public static void Main()
        {
            HashSet<string> cars = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] info = input.Split(", ");

                string command = info[0];
                string car = info[1];

                if (command == "IN")
                {
                    cars.Add(car);
                }
                else
                {
                    cars.Remove(car);
                }

                input = Console.ReadLine();
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
