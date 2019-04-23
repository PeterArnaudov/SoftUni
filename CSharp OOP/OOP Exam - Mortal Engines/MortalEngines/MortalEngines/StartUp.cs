namespace MortalEngines
{
    using MortalEngines.Core;
    using MortalEngines.Core.Contracts;
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            IPilotFactory pilotFactory = new PilotFactory();
            IMachineFactory machineFactory = new MachineFactory();
            IMachinesManager machinesManager = new MachinesManager(machineFactory, pilotFactory);
            IEngine engine = new Engine(machinesManager, pilotFactory, machineFactory);

            engine.Run();
        }
    }
}
