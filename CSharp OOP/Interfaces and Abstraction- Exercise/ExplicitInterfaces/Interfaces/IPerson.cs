namespace ExplicitInterfaces.Interfaces
{
    using System;

    public interface IPerson
    {
        string Name { get; }

        int Age { get; }

        string GetName();
    }
}
