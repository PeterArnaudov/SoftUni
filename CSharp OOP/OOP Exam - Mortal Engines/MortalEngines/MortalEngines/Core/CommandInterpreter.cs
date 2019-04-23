namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using System;

    public class CommandInterpreter : ICommandInterpreter
    {
        public ICommand Interpete(IMachinesManager machinesManager, string[] args)
        {
            string commandType = args[0] + "Command";

            Type type = Type.GetType("MortalEngines.Core.Commands." + commandType);

            if (type == null)
            {
                throw new ArgumentException("Invalid command!");
            }

            ICommand command = (ICommand)Activator.CreateInstance(type, new object[] { machinesManager, args });
            return command;
        }
    }
}
