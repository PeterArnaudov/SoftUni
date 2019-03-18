namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] info = Console.ReadLine().Split();

                if (info[0] == "END")
                {
                    break;
                }

                people.Add(new Person(info[0], int.Parse(info[1]), info[2]));
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            int equal = 0;
            int notEqual = 0;

            foreach (var person in people)
            {
                if (people[index].CompareTo(person) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notEqual} {people.Count}");
            }
        }
    }
}
