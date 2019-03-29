namespace InfernoInfinity.Interfaces
{
    using System;
    using InfernoInfinity.Models.Weapons;
    using System.Collections.Generic;

    public interface IRepository
    {
        List<IWeapon> Weapons { get; }

        void AddWeapon(IWeapon weapon);
    }
}
