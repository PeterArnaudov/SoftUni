namespace MilitaryElite.Classes.Soldiers.Privates.SpecialisedSoldiers
{
    using MilitaryElite.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<Repair>();
        }

        public List<Repair> Repairs
        {
            get => this.repairs;

            private set => this.repairs = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.Repairs.Count != 0)
            {
                sb.AppendLine();

                foreach (var repair in this.Repairs)
                {
                    sb.AppendLine($"  {repair.ToString()}");
                }
            }

            return $"{base.ToString()}{Environment.NewLine}Repairs:{sb.ToString().TrimEnd()}";
        }
    }
}
