namespace StorageMaster.Core.Factories
{
    using Models.Storages;
    using System;

    public class StorageFactory
    {
        public Storage CreateStorage(string type, string name)
        {
            if (type == "AutomatedWarehouse")
            {
                return new AutomatedWarehouse(name);
            }
            else if (type == "DistributionCenter")
            {
                return new DistributionCenter(name);
            }
            else if (type == "Warehouse")
            {
                return new Warehouse(name);
            }
            else
            {
                throw new InvalidOperationException("Invalid storage type!");
            }
        }
    }
}
