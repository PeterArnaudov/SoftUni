namespace MortalEngines.Core.Commands
{
    using System;
    using MortalEngines.Core.Contracts;

    public class PilotReportCommand : Command
    {
        public PilotReportCommand(IMachinesManager machinesManager, string[] args) 
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            string pilotName = this.Args[1];

            string output = this.WarMachinesManager.PilotReport(pilotName);

            return output;
        }
    }
}
