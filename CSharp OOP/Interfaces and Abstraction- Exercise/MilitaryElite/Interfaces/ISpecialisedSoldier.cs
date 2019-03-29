namespace MilitaryElite.Interfaces
{
    using System;

    public interface ISpecialisedSoldier : IPrivate
    {
        string Corps { get; }
    }
}
