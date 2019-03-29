namespace Vehicles
{
    using System;

    public class Car : Vehicle
    {
        private const double AdditionalConsumption = 0.9;

        public Car(double fuel, double fuelConsumption)
            : base(fuel, fuelConsumption)
        {
            this.AdditionalFuelConsumption = AdditionalConsumption;
        }

        protected override double AdditionalFuelConsumption { get; set; }
    }
}
