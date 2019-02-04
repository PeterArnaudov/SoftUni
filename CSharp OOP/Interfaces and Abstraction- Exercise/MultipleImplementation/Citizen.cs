namespace PersonInfo
{
    using System;

    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get => this.name;

            private set => this.name = value;
        }

        public int Age
        {
            get => this.age;

            private set => this.age = value;
        }

        public string Id
        {
            get => this.id;

            private set => this.id = value;
        }

        public string Birthdate
        {
            get => this.birthdate;

            private set => this.birthdate = value;
        }
    }
}
