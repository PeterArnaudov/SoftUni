namespace InfernoInfinity.Models.Weapons
{
    using System;

    public class Sword : Weapon
    {
        private const int BaseMinDamage = 4;
        private const int BaseMaxDamage = 6;
        private const int Sockets = 3;

        public Sword(string rarity, string name) 
            : base(rarity, name, BaseMinDamage, BaseMaxDamage, Sockets)
        {
        }
    }
}
