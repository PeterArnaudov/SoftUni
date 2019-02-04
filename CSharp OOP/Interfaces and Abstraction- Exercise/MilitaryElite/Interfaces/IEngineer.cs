namespace MilitaryElite.Interfaces
{
    using MilitaryElite.Classes;
    using System;
    using System.Collections.Generic;

    public interface IEngineer : ISpecialisedSoldier
    {
        List<Repair> Repairs { get; }
    }
}
