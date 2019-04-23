namespace MortalEngines.Entities.Contracts
{
    using System.Collections.Generic;

    public interface IPilot
    {
        string Name { get; }

        IReadOnlyCollection<IMachine> Machines { get; }

        void AddMachine(IMachine machine);

        string Report();
    }
}
