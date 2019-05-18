namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MachineFactory : IMachineFactory
    {
        public IFighter CreateFighter(string name, double attackPoints, double defensePoints)
        {
            return new Fighter(name, attackPoints, defensePoints);
        }

        public ITank CreateTank(string name, double attackPoints, double defensePoints)
        {
            return new Tank(name, attackPoints, defensePoints);
        }
    }
}
