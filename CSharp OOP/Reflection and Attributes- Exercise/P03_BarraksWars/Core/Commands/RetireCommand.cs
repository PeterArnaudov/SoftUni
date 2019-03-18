namespace _03BarracksFactory.Core.Commands
{
    using _03BarracksFactory.Contracts;

    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToRemove = this.UnitFactory.CreateUnit(unitType);
            this.Repository.RemoveUnit(unitType);
            return $"{unitType} retired!";
        }
    }
}
