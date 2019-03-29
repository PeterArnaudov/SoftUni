namespace RawData
{
    using System;

    public class Engine
    {
        public int Speed { get; set; }

        public int Power { get; set; }

        public Engine(int engineSpeed, int enginePower)
        {
            Speed = engineSpeed;
            Power = enginePower;
        }
    }
}
