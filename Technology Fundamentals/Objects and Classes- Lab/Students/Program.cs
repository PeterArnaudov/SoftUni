using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] information = input.Split();

                students.Add(ReadStudent(information));
            }

            string town = Console.ReadLine();

            students.Where(x => x.Hometown == town).ToList().ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old."));
        }

        public static Student ReadStudent(string[] information)
        {
            return new Student
            {
                FirstName = information[0],
                LastName = information[1],
                Age = int.Parse(information[2]),
                Hometown = information[3]
            };
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}
