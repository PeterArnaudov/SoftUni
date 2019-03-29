namespace StorageMaster.Core.Factories
{
    using Models.Products;
    using System;

    public class ProductFactory
    {
        public Product CreateProduct(string type, double price)
        {
            if (type == "Gpu")
            {
                return new Gpu(price);
            }
            else if (type == "HardDrive")
            {
                return new HardDrive(price);
            }
            else if (type == "Ram")
            {
                return new Ram(price);
            }
            else if (type == "SolidStateDrive")
            {
                return new SolidStateDrive(price);
            }
            else
            {
                throw new InvalidOperationException("Invalid product type!");
            }
        }
    }
}
