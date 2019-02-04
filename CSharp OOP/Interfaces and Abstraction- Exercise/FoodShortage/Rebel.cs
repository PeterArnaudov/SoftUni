namespace FoodShortage
{
    using System;

    public class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
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

        public string Group
        {
            get => this.group;

            private set => this.group = value;
        }

        public int Food
        {
            get => this.food;

            private set => this.food = value;
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
