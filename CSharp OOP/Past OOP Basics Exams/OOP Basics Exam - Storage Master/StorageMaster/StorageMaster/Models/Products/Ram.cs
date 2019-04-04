namespace StorageMaster.Models.Products
{
    using System;

    public class Ram : Product
    {
        private const double RamWeight = 0.1;

        public Ram(double price) 
            : base(price, RamWeight)
        {
        }
    }
}
