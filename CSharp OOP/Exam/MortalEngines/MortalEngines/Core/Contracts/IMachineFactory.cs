namespace MortalEngines.Core.Contracts
{
    using Entities.Contracts;

    public interface IMachineFactory
    {
        ITank CreateTank(string name, double attackPoints, double defensePoints);

        IFighter CreateFighter(string name, double attackPoints, double defensePoints);
    }
}
