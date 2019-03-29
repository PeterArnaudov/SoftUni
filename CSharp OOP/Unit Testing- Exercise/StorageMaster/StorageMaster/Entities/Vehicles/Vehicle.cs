namespace StorageMaster.Entities.Vehicles
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Products;

	public abstract class Vehicle
	{
		private readonly List<Product> trunk;

		protected Vehicle(int capacity)
		{
			this.Capacity = capacity;

			this.trunk = new List<Product>();
		}

		public int Capacity { get; }

		public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

		public bool IsFull => this.Trunk.Sum(c => c.Weight) >= Capacity;

		public bool IsEmpty => !this.Trunk.Any();

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
			if (!this.trunk.Any())
			{
				throw new InvalidOperationException("No products left in vehicle!");
			}

			var product = this.trunk.Last();
			this.trunk.RemoveAt(this.trunk.Count - 1);

			return product;
		}
	}
}