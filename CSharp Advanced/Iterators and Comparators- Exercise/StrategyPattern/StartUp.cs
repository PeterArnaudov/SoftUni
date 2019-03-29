namespace StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> peopleSortedByName = new SortedSet<Person>(new PersonNameComparer());
            SortedSet<Person> peopleSortedByAge = new SortedSet<Person>(new PersonAgeComparer());

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] info = Console.ReadLine().Split();
                Person person = new Person(info[0], int.Parse(info[1]));
                peopleSortedByName.Add(person);
                peopleSortedByAge.Add(person);
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(Environment.NewLine, peopleSortedByName));
            Console.WriteLine(string.Join(Environment.NewLine, peopleSortedByAge));
        }
    }
}
