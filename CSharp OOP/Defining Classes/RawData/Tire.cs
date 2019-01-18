namespace RawData
{
    using System;

    public class Tire
    {
        public double Pressure { get; set; }

        public int Age { get; set; }

        public Tire(double tierPressure, int tierAge)
        {
            Pressure = tierPressure;
            Age = tierAge;
        }
    }
}
