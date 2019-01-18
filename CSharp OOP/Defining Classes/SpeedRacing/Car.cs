namespace SpeedRacing
{
    using System;

    public class Car
    {
        public string Model { get; set; }

        public double Fuel { get; set; }

        public double Consumption { get; set; }

        public double Traveled { get; set; }

        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
            Traveled = 0;
        }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * Consumption;

            if (Fuel >= fuelNeeded)
            {
                Fuel -= fuelNeeded;
                Traveled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
