namespace StorageMaster.Core
{
    using Factories;
    using Models.Storages;
    using Models.Products;
    using Models.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StorageMaster
    {
        private ProductFactory productFactory;
        private StorageFactory storageFactory;
        private List<Product> productsPool;
        private List<Storage> storageRegistry;
        private Vehicle currentVehicle;

        public StorageMaster()
        {
            this.productFactory = new ProductFactory();
            this.storageFactory = new StorageFactory();
            this.productsPool = new List<Product>();
            this.storageRegistry = new List<Storage>();
        }

        public string AddProduct(string type, double price)
        {
            productsPool.Add(this.productFactory.CreateProduct(type, price));

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            storageRegistry.Add(this.storageFactory.CreateStorage(type, name));

            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            this.currentVehicle = storageRegistry.Find(s => s.Name == storageName).GetVehicle(garageSlot);

            return $"Selected {this.currentVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            foreach (var name in productNames)
            {
                if (!this.productsPool.Any(p => p.GetType().Name == name))
                {
                    throw new InvalidOperationException($"{name} is out of stock!");
                }

                Product product = productsPool.Last(p => p.GetType().Name == name);
                this.productsPool.Remove(product);

                if (this.currentVehicle.IsFull)
                {
                    break;
                }

                this.currentVehicle.LoadProduct(product);
            }

            return $"Loaded {this.currentVehicle.Trunk.Count}/{productNames.Count()} products into {this.currentVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (!this.storageRegistry.Any(s => s.Name == sourceName))
            {
                throw new InvalidOperationException("Invalid source storage!");
            }
            else if (!this.storageRegistry.Any(s => s.Name == destinationName))
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            Vehicle vehicle = storageRegistry.Find(s => s.Name == sourceName).GetVehicle(sourceGarageSlot);
            Storage storage = this.storageRegistry.Find(s => s.Name == destinationName);
            int destinationGarageSlot = storageRegistry.Find(s => s.Name == sourceName).SendVehicleTo(sourceGarageSlot, storage);

            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storageRegistry.Find(s => s.Name == storageName);

            Vehicle vehicle = storage.GetVehicle(garageSlot);
            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {unloadedProductsCount}/{vehicle.Trunk.Count} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storageRegistry.Find(s => s.Name == storageName);
            double productsWeightSum = storage.Products.Sum(x => x.Weight);

            StringBuilder sb = new StringBuilder();

            var products = storage.Products.GroupBy(x => x.GetType().Name).Select(g => new { Name = g.Key, Count = g.Count() }).ToList();

            List<string> output = new List<string>();
            foreach (var product in products.OrderByDescending(p => p.Count).ThenBy(p => p.Name))
            {
                output.Add(($"{product.Name} ({product.Count})"));
            }

            sb.AppendLine($"Stock ({productsWeightSum}/{storage.Capacity}): [{string.Join(", ", output)}]");
            output.Clear();

            foreach (var vehicle in storage.Garage)
            {
                if (vehicle == null)
                {
                    output.Add("empty");
                }
                else
                {
                    output.Add($"{vehicle.GetType().Name}");
                }
            }
            sb.AppendLine($"Garage: [{string.Join('|', output)}]");

            return sb.ToString().TrimEnd();
        }

        public string GetSummary()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var storage in this.storageRegistry.OrderByDescending(s => s.Products.Sum(p => p.Price)))
            {
                sb.AppendLine($"{storage.Name}:");
                sb.AppendLine($"Storage worth: ${storage.Products.Sum(p => p.Price):f2}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
