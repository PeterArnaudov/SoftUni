namespace StorageMaster.Models.Storages
{
    using StorageMaster.Models.Products;
    using StorageMaster.Models.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Storage
    {
        private Vehicle[] garage;
        private List<Product> products;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.garage = new Vehicle[garageSlots];

            for (int i = 0; i < vehicles.ToList().Count; i++)
            {
                this.garage[i] = vehicles.ToList()[i];
            }

            this.products = new List<Product>();
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public bool IsFull
        {
            get
            {
                if (this.products.Sum(x => x.Weight) >= this.Capacity)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public IReadOnlyCollection<Vehicle> Garage
        {
            get => this.garage;
        }

        public IReadOnlyCollection<Product> Products
        {
            get => this.products.AsReadOnly();
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            if (this.garage[garageSlot] == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return this.garage[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);

            this.garage[garageSlot] = null;

            int index = 0;
            for (int i = 0; i < deliveryLocation.garage.Length; i++)
            {
                if (deliveryLocation.garage[i] == null)
                {
                    deliveryLocation.garage[i] = vehicle;
                    index = i;
                    return index;
                }
            }

            throw new InvalidOperationException("No room in garage!");
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);

            int unloaded = 0;
            foreach (var product in vehicle.Trunk)
            {
                if (!this.IsFull)
                {
                    this.products.Add(product);
                    unloaded++;
                }
            }

            return unloaded;
        }
    }
}
