namespace StorageMaster.Models.Vehicles
{
    using System;

    public class Semi : Vehicle
    {
        private const int SemiCapacity = 10;

        public Semi() 
            : base(SemiCapacity)
        {
        }
    }
}
