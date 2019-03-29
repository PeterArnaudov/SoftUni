namespace InfernoInfinity.Models.Weapons
{
    using System;

    public class Knife : Weapon
    {
        private const int BaseMinDamage = 3;
        private const int BaseMaxDamage = 4;
        private const int Sockets = 2;

        public Knife(string rarity, string name) 
            : base(rarity, name, BaseMinDamage, BaseMaxDamage, Sockets)
        {
        }
    }
}
