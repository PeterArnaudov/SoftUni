namespace ExplicitInterfaces
{
    using System;
    using Interfaces;

    public class Citizen : IPerson, IResident
    {
        private string name;
        private string country;
        private int age;

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;

            private set => this.name = value;
        }

        public string Country
        {
            get => this.country;

            private set => this.country = value;
        }

        public int Age
        {
            get => this.age;

            private set => this.age = value;
        }

        string IPerson.GetName()
        {
            return this.Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
