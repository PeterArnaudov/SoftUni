namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> members = new List<Person>();
            Family family = new Family(members);

            for (int i = 0; i < lines; i++)
            {
                string[] info = Console.ReadLine().Split();

                family.Members.Add(new Person(info[0], int.Parse(info[1])));
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
