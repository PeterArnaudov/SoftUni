namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using MortalEngines.IO;
    using MortalEngines.IO.Contracts;
    using System;

    public class Engine : IEngine
    {
        private IMachinesManager machinesManager;
        private IPilotFactory pilotFactory;
        private IMachineFactory machineFactory;
        private ICommandInterpreter commandInterpreter;
        private IReader consoleReader;
        private IWriter consoleWriter;

        public Engine(IMachinesManager warMachinesManager, IPilotFactory pilotFactory, IMachineFactory machineFactory)
        {
            this.machinesManager = warMachinesManager;
            this.pilotFactory = pilotFactory;
            this.machineFactory = machineFactory;
            this.commandInterpreter = new CommandInterpreter();
            this.consoleReader = new ConsoleReader();
            this.consoleWriter = new ConsoleWriter();
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string[] args = this.consoleReader.ReadLine().Split();
                    string output = this.commandInterpreter.Interpete(this.machinesManager, args).Execute();

                    this.consoleWriter.WriteLine(output);
                }
                catch (Exception exception)
                {
                    this.consoleWriter.WriteLine(exception.Message);
                }
            }
        }
    }
}
