namespace MilitaryElite.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MilitaryElite.Interfaces;

    class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<Private> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<Private>();
        }

        public List<Private> Privates
        {
            get => this.privates;

            private set => this.privates = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.Privates.Count != 0)
            {
                sb.AppendLine();

                foreach (var pr in this.Privates)
                {
                    sb.AppendLine($"  {pr.ToString()}");
                }
            }

            return $"{base.ToString()}{Environment.NewLine}Privates:{sb.ToString().TrimEnd()}";
        }
    }
}
