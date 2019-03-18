﻿namespace KingsGambit
{
    using System;

    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name) 
            : base(name)
        {
        }

        public override void KingUnderAttack()
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
