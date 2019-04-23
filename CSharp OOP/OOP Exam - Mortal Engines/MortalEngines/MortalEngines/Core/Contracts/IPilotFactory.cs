namespace MortalEngines.Core.Contracts
{
    using Entities.Contracts;

    public interface IPilotFactory
    {
        IPilot CreatePilot(string name);
    }
}
