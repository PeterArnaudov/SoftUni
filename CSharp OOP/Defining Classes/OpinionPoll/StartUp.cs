namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] info = Console.ReadLine().Split();

                people.Add(new Person(info[0], int.Parse(info[1])));
            }

            List<Person> filteredPeople = people.Where(x => x.Age > 30).ToList();

            foreach (var person in filteredPeople.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
