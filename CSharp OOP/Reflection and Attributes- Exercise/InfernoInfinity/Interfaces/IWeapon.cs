namespace InfernoInfinity.Interfaces
{
    using InfernoInfinity.Models.Gems;
    using System;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        void AddGem(IGem gem, int index);

        void RemoveGem(int index);

        string ToString();
    }
}
