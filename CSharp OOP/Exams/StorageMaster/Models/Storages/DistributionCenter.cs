namespace StorageMaster.Models.Storages
{
    using StorageMaster.Models.Vehicles;

    public class DistributionCenter : Storage
    {
        private const int DistributionCenterCapacity = 2;
        private const int DistributionCenterGarageSlots = 5;

        public DistributionCenter(string name) 
            : base(name, DistributionCenterCapacity, DistributionCenterGarageSlots, new Vehicle[] { new Van(), new Van(), new Van() })
        {
        }
    }
}
