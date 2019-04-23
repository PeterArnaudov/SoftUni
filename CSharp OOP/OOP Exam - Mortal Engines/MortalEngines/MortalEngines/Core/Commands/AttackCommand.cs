namespace MortalEngines.Core.Commands
{
    using System;
    using MortalEngines.Core.Contracts;

    public class AttackCommand : Command
    {
        public AttackCommand(IMachinesManager machinesManager, string[] args) 
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            string attackingMachineName = this.Args[1];
            string defendingMachineName = this.Args[2];

            string output = this.WarMachinesManager.AttackMachines(attackingMachineName, defendingMachineName);

            return output;
        }
    }
}
