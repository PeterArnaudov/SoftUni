using MilitaryElite.Interfaces;
using System;

namespace MilitaryElite.Classes
{
    public class Private : Soldier, ISoldier, IPrivate
    {
        private decimal salary;

        public Private(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get => this.salary;

            private set => this.salary = value;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:f2}";
        }
    }
}
