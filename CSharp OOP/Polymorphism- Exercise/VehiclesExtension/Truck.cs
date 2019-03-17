namespace VehiclesExtension
{
    using System;

    public class Truck : Vehicle
    {
        private const double AdditionalConsumption = 1.6;
        private const double RefuelingCoeficient = 0.95;

        public Truck(double fuel, double fuelConsumption, double tankCapacity)
            : base(fuel, fuelConsumption, tankCapacity)
        {
            this.AdditionalFuelConsumption = AdditionalConsumption;
        }

        protected override double AdditionalFuelConsumption { get; set; }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);
            this.Fuel -= (1 - RefuelingCoeficient) * fuel;
        }
    }
}
