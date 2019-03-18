namespace InfernoInfinity.Core.Factories
{
    using InfernoInfinity.Interfaces;
    using InfernoInfinity.Models.Weapons;
    using System;
    using System.Reflection;

    public static class WeaponFactory
    {
        public static IWeapon CreateWeapon(string weaponRarity, string weaponType, string weaponName)
        {
            Type type = Type.GetType("InfernoInfinity.Models.Weapons." + weaponType);
            return (IWeapon)Activator.CreateInstance(type, weaponRarity, weaponName);
        }
    }
}
