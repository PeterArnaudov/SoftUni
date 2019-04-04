namespace StorageMaster.Models.Storages
{
    using StorageMaster.Models.Vehicles;

    public class Warehouse : Storage
    {
        private const int WarehouseCapacity = 10;
        private const int WarehouseGarageSlots = 10;

        public Warehouse(string name) 
            : base(name, WarehouseCapacity, WarehouseGarageSlots, new Vehicle[] { new Semi(), new Semi(), new Semi() })
        {
        }
    }
}
