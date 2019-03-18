namespace StorageMaster.Models.Vehicles
{
    using StorageMaster.Models.Products;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Vehicle
    {
        private List<Product> trunk;

        public Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new List<Product>();
        }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<Product> Trunk
        {
            get => this.trunk;
        }

        public bool IsFull
        {
            get
            {
                if (this.trunk.Sum(x => x.Weight) >= this.Capacity)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (!this.trunk.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            Product toReturn = this.trunk.Last();
            this.trunk.RemoveAt(this.trunk.Count - 1);
            return toReturn;
        }
    }
}
