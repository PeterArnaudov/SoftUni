namespace MortalEngines.Core.Commands
{
    using System;
    using MortalEngines.Core.Contracts;

    public class ManufactureFighterCommand : Command
    {
        public ManufactureFighterCommand(IMachinesManager machinesManager, string[] args) 
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            string machineName = this.Args[1];
            double attackPoints = double.Parse(this.Args[2]);
            double defensePoints = double.Parse(this.Args[3]);

            string output = this.WarMachinesManager.ManufactureFighter(machineName, attackPoints, defensePoints);

            return output;
        }
    }
}
