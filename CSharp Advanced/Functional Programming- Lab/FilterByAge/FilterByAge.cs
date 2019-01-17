namespace FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterByAge
    {
        public static void Main()
        {
            Dictionary<string, int> people = GetPeople();

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> ageCondition = CreateFunc(condition, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            Print(people, ageCondition, printer);
        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            if (format == "name")
            {
                return x => Console.WriteLine(x.Key);
            }
            else if (format == "age")
            {
                return x => Console.WriteLine(x.Value);
            }
            else if (format == "name age")
            {
                return x => Console.WriteLine($"{x.Key} - {x.Value}");
            }

            return null;
        }

        public static Func<int, bool> CreateFunc(string condition, int age)
        {
            if (condition == "younger")
            {
                return x => x < age;
            }
            else if (condition == "older")
            {
                return x => x >= age;
            }

            return null;
        }

        public static void Print(Dictionary<string, int> people, Func<int, bool> ageCondition, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (ageCondition(person.Value))
                {
                    printer(person);
                }
            }
        }

        public static Dictionary<string, int> GetPeople()
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < lines; i++)
            {
                string[] info = Console.ReadLine().Split(", ");
                people.Add(info[0], int.Parse(info[1]));
            }

            return people;
        }
    }
}
