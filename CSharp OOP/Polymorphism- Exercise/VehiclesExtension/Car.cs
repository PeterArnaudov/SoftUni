namespace VehiclesExtension
{
    using System;

    public class Car : Vehicle
    {
        private const double AdditionalConsumption = 0.9;

        public Car(double fuel, double fuelConsumption, double tankCapacity)
            : base(fuel, fuelConsumption, tankCapacity)
        {
            this.AdditionalFuelConsumption = AdditionalConsumption;
        }

        protected override double AdditionalFuelConsumption { get; set; }
    }
}
