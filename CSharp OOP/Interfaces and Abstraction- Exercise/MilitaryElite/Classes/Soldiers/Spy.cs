namespace MilitaryElite.Classes.Soldiers
{
    using MilitaryElite.Interfaces;
    using System;

    public class Spy : Soldier, ISpy
    {
        private int codeNumber;

        public Spy(string id, string firstName, string lastName, int codeNumber)
            :base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber
        {
            get => this.codeNumber;

            private set => this.codeNumber = value;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Code Number: {this.CodeNumber}";
        }
    }
}
