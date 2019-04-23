namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;

    public class Tank : BaseMachine, ITank
    {
        private const int InitialHealthPoints = 100;
        private const int AttackPointsModifier = 40;
        private const int DefensePointsModifier = 30;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefensePointsModifier;
                this.DefenseMode = false;
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefensePointsModifier;
                this.DefenseMode = true;
            }
        }

        public override string ToString()
        {
            string defense = this.DefenseMode ? "\r\n *Defense: ON" : "\r\n *Defense: OFF";
            return base.ToString() + defense;
        }
    }
}
