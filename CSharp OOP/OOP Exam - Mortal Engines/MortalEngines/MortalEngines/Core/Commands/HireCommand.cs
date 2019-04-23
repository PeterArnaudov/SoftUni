namespace MortalEngines.Core.Commands
{
    using System;
    using MortalEngines.Core.Contracts;

    public class HireCommand : Command
    {
        public HireCommand(IMachinesManager machinesManager, string[] args)
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            string pilotName = this.Args[1];

            string output = this.WarMachinesManager.HirePilot(pilotName);

            return output;
        }
    }
}
