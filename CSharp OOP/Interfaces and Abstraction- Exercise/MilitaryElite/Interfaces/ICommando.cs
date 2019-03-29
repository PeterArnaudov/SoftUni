namespace MilitaryElite.Interfaces
{
    using MilitaryElite.Classes;
    using System;
    using System.Collections.Generic;

    public interface ICommando : ISpecialisedSoldier
    {
        List<Mission> Missions { get; }
    }
}
