namespace VehiclesExtension
{
    using System;

    public class Bus : Vehicle
    {
        private const double AdditionalConsumption = 1.4;

        private bool airConditioner = false;

        public Bus(double fuel, double fuelConsumption, double tankCapacity)
            : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalFuelConsumption
        {
            get => airConditioner ? 1.4 : 0;

            set => this.AdditionalFuelConsumption = value;
        }

        public void TurnAirConditionerOn()
        {
            this.airConditioner = true;
        }

        public void TurnAirConditionerOff()
        {
            this.airConditioner = false;
        }
    }
}
