namespace StrategyPattern
{
    using System;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => this.name;

        public int Age => this.age;

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
