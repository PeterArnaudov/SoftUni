namespace MortalEngines.Core.Commands
{
    using System;
    using MortalEngines.Core.Contracts;

    public class QuitCommand : Command
    {
        public QuitCommand(IMachinesManager machinesManager, string[] args) 
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return null;
        }
    }
}
