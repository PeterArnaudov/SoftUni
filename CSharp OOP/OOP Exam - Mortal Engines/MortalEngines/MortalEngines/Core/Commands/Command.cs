namespace MortalEngines.Core.Commands
{
    using MortalEngines.Core.Contracts;
    using System;

    public abstract class Command : ICommand
    {
        private string[] args;
        private IMachinesManager machinesManager;

        public Command(IMachinesManager warMachinesManager, string[] args)
        {
            this.args = args;
            this.machinesManager = warMachinesManager;
        }

        protected string[] Args => this.args;

        protected IMachinesManager WarMachinesManager => this.machinesManager;

        public abstract string Execute();
    }
}
