namespace ExplicitInterfaces.Interfaces
{
    using System;

    public interface IResident
    {
        string Name { get; }

        string Country { get; }

        string GetName();
    }
}
