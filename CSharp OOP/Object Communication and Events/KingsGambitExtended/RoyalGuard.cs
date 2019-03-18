namespace KingsGambitExtended
{
    using System;

    public class RoyalGuard : Soldier
    {
        private const int InitialHealth = 3;

        public RoyalGuard(string name)
            : base(name, InitialHealth)
        {
        }

        public override void KingUnderAttack()
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
