namespace InfernoInfinity.Models.Weapons
{
    using System;

    public class Axe : Weapon
    {
        private const int BaseMinDamage = 5;
        private const int BaseMaxDamage = 10;
        private const int Sockets = 4;

        public Axe(string rarity, string name) 
            : base(rarity, name, BaseMinDamage, BaseMaxDamage, Sockets)
        {
        }
    }
}
