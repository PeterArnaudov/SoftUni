namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PilotFactory : IPilotFactory
    {
        public IPilot CreatePilot(string name)
        {
            return new Pilot(name);
        }
    }
}
