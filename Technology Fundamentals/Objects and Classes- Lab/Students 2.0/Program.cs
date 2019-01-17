using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_2._0
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

                students = AddStudent(students, information);
            }

            string town = Console.ReadLine();

            students.Where(x => x.Hometown == town).ToList().ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old."));
        }

        public static List<Student> AddStudent(List<Student> students ,string[] information)
        {
            Student newStudent = ReadStudent(information);

            if (students.Any(x => x.FirstName == newStudent.FirstName && x.LastName == newStudent.LastName))
            {
                int index = students.FindIndex(x => x.FirstName == newStudent.FirstName && x.LastName == newStudent.LastName);

                students[index].Age = newStudent.Age;
                students[index].Hometown = newStudent.Hometown;
            }
            else
            {
                students.Add(newStudent);
            }

            return students;
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
