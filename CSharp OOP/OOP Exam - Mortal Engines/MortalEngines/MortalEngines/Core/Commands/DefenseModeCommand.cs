namespace MortalEngines.Core.Commands
{
    using System;
    using MortalEngines.Core.Contracts;

    public class DefenseModeCommand : Command
    {
        public DefenseModeCommand(IMachinesManager machinesManager, string[] args) 
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            string tankName = this.Args[1];

            string output = this.WarMachinesManager.ToggleTankDefenseMode(tankName);

            return output;
        }
    }
}
