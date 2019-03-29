using _03BarracksFactory.Contracts;
using _03BarracksFactory.CustomAttributes;

namespace _03BarracksFactory.Core.Commands
{
    public abstract class Command : IExecutable
    {
        [Inject]
        private string[] data;

        [Inject]
        private IRepository repository;

        [Inject]
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        protected string[] Data
        {
            get => this.data;

            private set => this.data = value;
        }

        protected IRepository Repository
        {
            get => this.repository;

            private set => this.repository = value;
        }

        protected IUnitFactory UnitFactory
        {
            get => this.unitFactory;

            private set => this.unitFactory = value;
        }

        public abstract string Execute();
    }
}
