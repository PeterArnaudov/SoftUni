namespace MortalEngines.Core.Contracts
{
    using System;

    public interface ICommandInterpreter
    {
        ICommand Interpete(IMachinesManager machineManagers, string[] args);
    }
}
