namespace MortalEngines.Core.Commands
{
    using System;
    using MortalEngines.Core.Contracts;

    public class EngageCommand : Command
    {
        public EngageCommand(IMachinesManager machinesManager, string[] args) 
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            string selectedPilotName = this.Args[1];
            string selectedMachineName = this.Args[2];

            string output = this.WarMachinesManager.EngageMachine(selectedPilotName, selectedMachineName);

            return output;
        }
    }
}
