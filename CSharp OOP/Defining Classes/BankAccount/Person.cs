namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<BankAccount> Accounts { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Accounts = new List<BankAccount>();
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            Name = name;
            Age = age;
            Accounts = accounts;
        }

        public decimal GetBalance()
        {
            return Accounts.Sum(a => a.Balance);
        }
    }
}
