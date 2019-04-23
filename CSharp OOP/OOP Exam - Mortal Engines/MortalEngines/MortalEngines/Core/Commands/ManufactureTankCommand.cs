namespace MortalEngines.Core.Commands
{
    using System;
    using MortalEngines.Core.Contracts;

    public class ManufactureTankCommand : Command
    {
        public ManufactureTankCommand(IMachinesManager machinesManager, string[] args) 
            : base(machinesManager, args)
        {
        }

        public override string Execute()
        {
            string machineName = this.Args[1];
            double attackPoints = double.Parse(this.Args[2]);
            double defensePoints = double.Parse(this.Args[3]);

            string output = this.WarMachinesManager.ManufactureTank(this.Args[1], double.Parse(this.Args[2]), double.Parse(this.Args[3]));

            return output;
        }
    }
}
