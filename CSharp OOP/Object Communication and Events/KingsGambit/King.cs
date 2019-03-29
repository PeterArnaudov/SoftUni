namespace KingsGambit
{
    using System;

    public delegate void KingUnderAttackHandler();

    public class King
    {
        public event KingUnderAttackHandler UnderAttack;

        public King(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void OnAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            UnderAttack?.Invoke();
        }
    }
}
