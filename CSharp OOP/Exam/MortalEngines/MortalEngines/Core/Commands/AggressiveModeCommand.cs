namespace MortalEngines.Core.Commands
{
    using System;
    using MortalEngines.Core.Contracts;

    public class AggressiveModeCommand : Command
    {
        public AggressiveModeCommand(IMachinesManager machinesManager, string[] args) 
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            string fighterName = this.Args[1];

            string output = this.WarMachinesManager.ToggleFighterAggressiveMode(fighterName);

            return output;
        }
    }
}
