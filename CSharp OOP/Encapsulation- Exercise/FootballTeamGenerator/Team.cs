namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
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

        public double GetRating()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }
            else
            {
                return this.players.Select(p => p.SkillLevel).Average();
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.Any(p => p.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.Remove(players.Find(p => p.Name == playerName));
        }

        public void PrintRating()
        {
            Console.WriteLine($"{this.Name} - {Math.Round((this.GetRating()))}");
        }
    }
}
