namespace _03BarracksFactory.Core.Commands
{
    using _03BarracksFactory.Contracts;

    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            return this.Repository.Statistics;
        }
    }
}
