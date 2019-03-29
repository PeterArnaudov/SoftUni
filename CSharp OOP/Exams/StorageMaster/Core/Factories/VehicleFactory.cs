namespace StorageMaster.Core.Factories
{
    using Models.Vehicles;
    using System;

    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string type)
        {
            if (type == "Semi")
            {
                return new Semi();
            }
            else if (type == "Truck")
            {
                return new Truck();
            }
            else if (type == "Van")
            {
                return new Van();
            }
            else
            {
                throw new InvalidOperationException("Invalid vehicle type!");
            }
        }
    }
}
