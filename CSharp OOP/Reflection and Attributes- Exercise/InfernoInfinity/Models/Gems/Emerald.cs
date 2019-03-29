namespace InfernoInfinity.Models.Gems
{
    using System;

    public class Emerald : Gem
    {
        private const int BaseStrength = 1;
        private const int BaseAgility = 4;
        private const int BaseVitality = 9;

        public Emerald(string clarity)
            : base(clarity, BaseStrength, BaseAgility, BaseVitality)
        {
        }
    }
}
