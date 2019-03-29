namespace Cars.Cars
{
    using System;

    public interface IElectricCar : ICar
    {
        int Battery { get; }
    }
}
