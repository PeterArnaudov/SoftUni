using MortalEngines.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Core.Commands
{
    public class MachineReportCommand : Command
    {
        public MachineReportCommand(IMachinesManager machinesManager, string[] args)
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            string pilotName = this.Args[1];

            string output = this.WarMachinesManager.MachineReport(pilotName);

            return output;
        }
    }
}
