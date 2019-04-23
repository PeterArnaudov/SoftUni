namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Fighter : BaseMachine, IFighter
    {
        private const int InitialHealthPoints = 200;
        private const int AttackPointsModifier = 50;
        private const int DefensePointsModifier = 25;

        public Fighter(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleAggressiveMode();
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (this.AggressiveMode)
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefensePointsModifier;
                this.AggressiveMode = false;
            }
            else
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefensePointsModifier;
                this.AggressiveMode = true;
            }
        }

        public override string ToString()
        {
            string agressive = this.AggressiveMode ? "\r\n *Aggressive: ON" : "\r\n *Aggressive: OFF";
            return base.ToString() + agressive;
        }
    }
}
