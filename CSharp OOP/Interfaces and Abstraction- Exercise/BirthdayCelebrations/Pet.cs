namespace BirthdayCelebrations
{
    using BirthdayCelebrations.Interfaces;
    using System;

    public class Pet : IBirthable
    {
        private string name;
        private DateTime birthdate;

        public Pet(string name, DateTime birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get => this.name;

            private set => this.name = value;
        }

        public DateTime Birthdate
        {
            get => this.birthdate;

            private set => this.birthdate = value;
        }
    }
}
