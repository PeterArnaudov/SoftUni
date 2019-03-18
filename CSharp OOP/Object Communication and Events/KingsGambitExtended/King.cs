namespace KingsGambitExtended
{
    using System;
    using System.Collections.Generic;

    public delegate void KingUnderAttackHandler();

    public class King
    {
        public event KingUnderAttackHandler UnderAttack;

        private List<Soldier> soldiers;

        public King(string name)
        {
            this.Name = name;
            this.soldiers = new List<Soldier>();
        }

        public void AddSoldier(Soldier soldier)
        {
            this.soldiers.Add(soldier);
            UnderAttack += soldier.KingUnderAttack;
            soldier.SoldierDead += this.OnSoldierDead;
        }

        public string Name { get; private set; }

        public IReadOnlyCollection<Soldier> Soldiers => this.soldiers;

        public void OnAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            UnderAttack?.Invoke();
        }

        public void OnSoldierDead(Soldier soldier)
        {
            this.UnderAttack -= soldier.KingUnderAttack;
            this.soldiers.Remove(soldier);
        }
    }
}
