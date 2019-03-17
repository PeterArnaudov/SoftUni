namespace Vehicles
{
    using System;

    public abstract class Vehicle
    {
        private double fuel;
        private double fuelConsumption;

        public Vehicle(double fuel, double fuelConsumption)
        {
            this.fuel = fuel;
            this.fuelConsumption = fuelConsumption;
        }

        protected abstract double AdditionalFuelConsumption { get; set; }

        public string Drive(double distance)
        {
            if (this.fuel < (fuelConsumption + AdditionalFuelConsumption) * distance)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            else
            {
                this.fuel -= (fuelConsumption + AdditionalFuelConsumption) * distance;
                return $"{this.GetType().Name} travelled {distance} km";
            }
        }

        public virtual void Refuel(double fuel)
        {
            this.fuel += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuel:f2}";
        }
    }
}
