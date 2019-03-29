namespace PersonsInfo
{
    using System;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName { get; }

        public int Age { get; }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public void IncreaseSalary(decimal bonus)
        {
            if (this.age < 30)
            {
                bonus /= 2;
            }

            this.salary += salary * (bonus / 100);
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {this.salary:f2} leva.";
        }
    }
}
