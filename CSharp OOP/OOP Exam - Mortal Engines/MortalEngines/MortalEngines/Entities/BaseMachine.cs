namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;

    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double attackPoints;
        private double defencePoints;
        private double healthPoints;
        private List<string> targets;

        public BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Machine name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get => this.pilot;

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Pilot cannot be null.");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get => this.healthPoints;

            set => this.healthPoints = value;
        }

        public double AttackPoints
        {
            get => this.attackPoints;

            protected set => this.attackPoints = value;
        }

        public double DefensePoints
        {
            get => this.defencePoints;

            protected set => this.defencePoints = value;
        }

        public IReadOnlyCollection<string> Targets
        {
            get => this.targets;
        }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                throw new NullReferenceException("Target cannot be null");
            }

            double damageTaken = this.AttackPoints - target.DefensePoints;
            if (damageTaken > 0 || target.HealthPoints <= 0 || target.HealthPoints <= 0)
            {
                target.HealthPoints -= damageTaken;

                if (target.HealthPoints < 0)
                {
                    target.HealthPoints = 0;
                }
            }

            this.targets.Add(target.Name);
        }

        public override string ToString()
        {
            string targets = this.targets.Count == 0 ? "None" : string.Join(", ", this.targets);

            return $"- {this.name}\r\n *Type: {this.GetType().Name}\r\n *Health: {this.healthPoints:f2}\r\n *Attack: {this.attackPoints:f2}\r\n *Defense: {this.defencePoints:f2}\r\n *Targets: {targets}";
        }
    }
}
