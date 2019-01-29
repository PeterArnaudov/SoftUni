namespace FootballTeamGenerator
{
    using System;

    public class Player
    {
        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;
        private double skillLevel;

        public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            this.skillLevel = (endurance + sprint + dribble + passing + shooting) / 5;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public double SkillLevel
        {
            get
            {
                return this.skillLevel;
            }
        }

        private double Endurance
        {
            set
            {
                ValidateStat(value, nameof(this.Endurance));
                this.endurance = value;
            }
        }

        private double Sprint
        {
            set
            {
                ValidateStat(value, nameof(this.Sprint));
                this.sprint = value;
            }
        }

        private double Dribble
        {
            set
            {
                ValidateStat(value, nameof(this.Dribble));
                this.dribble = value;
            }
        }

        private double Passing
        {
            set
            {
                ValidateStat(value, nameof(this.Passing));
                this.passing = value;
            }
        }

        private double Shooting
        {
            set
            {
                ValidateStat(value, nameof(this.Shooting));
                this.shooting = value;
            }
        }

        private void ValidateStat(double statValue, string statName)
        {
            if (statValue < 0 || statValue > 100)
            {
                throw new ArgumentException($"{statName} should be between 0 and 100.");
            }
        }
    }
}
