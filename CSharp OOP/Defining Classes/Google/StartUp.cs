namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] info = command.Split();

                if (!people.Any(x => x.Name == info[0]))
                {
                    people.Add(new Person(info[0]));
                }

                UpdateInformation(people.Find(x => x.Name == info[0]), info);
            }

            string name = Console.ReadLine();
            Console.WriteLine(people.Find(x => x.Name == name).ToString());
        }

        public static void UpdateInformation(Person person, string[] info)
        {
            if (info[1] == "company")
            {
                Company company = new Company(info[2], info[3], double.Parse(info[4]));
                person.Company = company;
            }
            else if (info[1] == "car")
            {
                Car car = new Car(info[2], int.Parse(info[3]));
                person.Car = car;
            }
            else if (info[1] == "parents")
            {
                Parent parent = new Parent(info[2], info[3]);
                person.Parents.Add(parent);
            }
            else if (info[1] == "children")
            {
                Child child = new Child(info[2], info[3]);
                person.Children.Add(child);
            }
            else if (info[1] == "pokemon")
            {
                Pokemon pokemon = new Pokemon(info[2], info[3]);
                person.Pokemons.Add(pokemon);
            }
        }
    }
}
