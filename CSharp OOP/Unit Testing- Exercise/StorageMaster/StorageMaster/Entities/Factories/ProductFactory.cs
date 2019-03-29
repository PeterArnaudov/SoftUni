namespace StorageMaster.Entities.Factories
{
	using System;
	using System.Linq;
	using System.Reflection;
	using Products;

	public class ProductFactory
	{
		public Product CreateProduct(string type, double price)
		{
			var productType = this.GetType()
				.Assembly
				.GetTypes()
				.FirstOrDefault(t => typeof(Product).IsAssignableFrom(t) && !t.IsAbstract && t.Name == type);

			if (productType == null)
			{
				throw new InvalidOperationException("Invalid product type!");
			}

			try
			{
				var product = (Product)Activator.CreateInstance(productType, price);
				return product;
			}
			catch (TargetInvocationException e)
			{
				throw e.InnerException;
			}
			
		}
	}
}