namespace MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers
{
    using MilitaryElite.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<Mission> missions;

        public Commando(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<Mission>();
        }

        public List<Mission> Missions
        {
            get => this.missions;

            private set => this.missions = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.Missions.Count != 0)
            {
                sb.AppendLine();

                foreach (var mission in this.Missions)
                {
                    sb.AppendLine($"  {mission.ToString()}");
                }
            }

            return $"{base.ToString()}{Environment.NewLine}Missions:{sb.ToString().TrimEnd()}";
        }
    }
}
