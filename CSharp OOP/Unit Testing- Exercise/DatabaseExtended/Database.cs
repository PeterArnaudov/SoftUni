namespace DatabaseExtended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database
    {
        private List<Person> people;

        public Database()
        {
            this.people = new List<Person>();
        }

        public IReadOnlyList<Person> People => this.people;

        public void Add(long id, string username)
        {
            if (people.Any(p => p.Id == id))
            {
                throw new InvalidOperationException("Person with the same ID exists.");
            }
            else if (people.Any(p => p.Username == username))
            {
                throw new InvalidOperationException("Person with the same username exists.");
            }

            Person person = new Person(id, username);
            this.people.Add(person);
        }

        public void Remove(long id)
        {
            Person person = this.people.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                throw new InvalidOperationException("Person with this ID doesn't exist.");
            }

            this.people.Remove(person);
        }

        public void Remove(string username)
        {
            Person person = this.people.FirstOrDefault(p => p.Username == username);

            if (person == null)
            {
                throw new InvalidOperationException("Person with this username doesn't exist.");
            }

            this.people.Remove(person);
        }

        public Person FindByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username cannot be null or empty.");
            }

            Person person = this.people.FirstOrDefault(p => p.Username == username);

            if (person == null)
            {
                throw new InvalidOperationException("Person with this username doesn't exist.");
            }

            return person;
        }

        public Person FindById(long id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("ID cannot be negative or 0.");
            }

            Person person = this.people.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                throw new InvalidOperationException("Person with this ID doesn't exist.");
            }

            return person;
        }
    }
}
