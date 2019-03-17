namespace VehiclesExtension
{
    using System;

    public abstract class Vehicle
    {
        private double fuel;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuel, double fuelConsumption, double tankCapacity)
        {
            if (fuel > tankCapacity)
            {
                this.Fuel = 0;
            }
            else
            {
                this.Fuel = fuel;
            }

            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = tankCapacity;
        }

        protected abstract double AdditionalFuelConsumption { get; set; }

        protected double Fuel
        {
            get => this.fuel;

            set => this.fuel = value;
        }

        public string Drive(double distance)
        {
            if (this.fuel < (this.fuelConsumption + this.AdditionalFuelConsumption) * distance)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            else
            {
                this.fuel -= (this.fuelConsumption + this.AdditionalFuelConsumption) * distance;
                return $"{this.GetType().Name} travelled {distance} km";
            }
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (this.tankCapacity - this.fuel < fuel)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            this.Fuel += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuel:f2}";
        }
    }
}
