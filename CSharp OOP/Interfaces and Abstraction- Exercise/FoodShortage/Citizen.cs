namespace FoodShortage
{
    using System;

    public class Citizen : IBuyer
    {
        private string name;
        private int age;
        private string id;
        private DateTime birthdate;
        private int food;

        public Citizen(string name, int age, string id, DateTime birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
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

        public DateTime Birthdate
        {
            get => this.birthdate;

            private set => this.birthdate = value;
        }

        public int Food
        {
            get => this.food;

            private set => this.food = value;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
