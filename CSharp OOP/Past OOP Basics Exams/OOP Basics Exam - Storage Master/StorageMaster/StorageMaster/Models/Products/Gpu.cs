namespace StorageMaster.Models.Products
{
    using System;

    public class Gpu : Product
    {
        private const double GpuWeight = 0.7;

        public Gpu(double price) 
            : base(price, GpuWeight)
        {
        }
    }
}
