namespace StorageMaster.Models.Vehicles
{
    using System;

    public class Van : Vehicle
    {
        private const int VanCapacity = 2;

        public Van() 
            : base(VanCapacity)
        {
        }
    }
}
