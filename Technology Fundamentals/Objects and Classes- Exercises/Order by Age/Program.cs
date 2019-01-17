using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_by_Age
{
    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] information = input.Split();

                people.Add(new Person(information));
            }

            people.OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine($"{x.Name} with ID: {x.ID} is {x.Age} years old."));
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string[] information)
        {
            Name = information[0];
            ID = information[1];
            Age = int.Parse(information[2]);
        }
    }
}
