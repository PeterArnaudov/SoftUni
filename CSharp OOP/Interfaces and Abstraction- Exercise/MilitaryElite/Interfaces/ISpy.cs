namespace MilitaryElite.Interfaces
{
    using System;

    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
