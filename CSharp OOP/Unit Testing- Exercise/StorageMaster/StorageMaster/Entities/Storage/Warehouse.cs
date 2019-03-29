namespace StorageMaster.Entities.Storage
{
	using Vehicles;

	public class Warehouse : Storage
	{
		private static readonly Vehicle[] DefaultVehicles =
		{
			new Semi(), new Semi(), new Semi()
		};

		public Warehouse(string name)
			: base(name, capacity: 10, garageSlots: 10, vehicles: DefaultVehicles)
		{
		}
	}
}