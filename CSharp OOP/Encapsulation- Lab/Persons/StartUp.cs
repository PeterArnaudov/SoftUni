namespace PersonsInfo
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
                people.Add(new Person(info[0], info[1], int.Parse(info[2])));
            }

            people.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
