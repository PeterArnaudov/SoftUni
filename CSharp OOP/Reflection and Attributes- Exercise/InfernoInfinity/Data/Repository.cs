namespace InfernoInfinity.Data
{
    using System;
    using System.Collections.Generic;
    using InfernoInfinity.Interfaces;
    using InfernoInfinity.Models.Weapons;

    public class Repository : IRepository
    {
        private List<IWeapon> weapons;

        public Repository()
        {
            weapons = new List<IWeapon>();
        }

        public List<IWeapon> Weapons => this.weapons;

        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.Add(weapon);
        }
    }
}
