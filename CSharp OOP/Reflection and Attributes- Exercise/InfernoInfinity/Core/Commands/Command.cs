namespace InfernoInfinity.Core.Commands
{
    using InfernoInfinity.Core.Factories;
    using InfernoInfinity.Data;
    using InfernoInfinity.Interfaces;
    using System;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        
        public Command(IRepository repository, string[] data)
        {
            this.repository = repository;
            this.data = data;
        }

        protected string[] Data => this.data;

        protected IRepository Repository => this.repository;

        public abstract void Execute();
    }
}
