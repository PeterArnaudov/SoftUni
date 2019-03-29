namespace PersonsInfo
{
    using System;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName { get; }

        public int Age { get; }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} is {this.age} years old.";
        }
    }
}
