namespace StorageMaster.Models.Products
{
    using System;

    public class SolidStateDrive : Product
    {
        private const double SolidStateDriveWeight = 0.2;

        public SolidStateDrive(double price) 
            : base(price, SolidStateDriveWeight)
        {
        }
    }
}
