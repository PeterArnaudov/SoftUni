﻿namespace KingsGambit
{
    using System;

    public class Footman : Soldier
    {
        public Footman(string name) 
            : base(name)
        {
        }

        public override void KingUnderAttack()
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
