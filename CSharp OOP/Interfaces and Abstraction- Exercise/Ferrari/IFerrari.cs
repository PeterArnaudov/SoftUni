namespace Ferrari
{
    using System;

    public interface IFerrari
    {
        string Model { get; }

        string Driver { get; }

        string UseBreaks();

        string PushGas();
    }
}
