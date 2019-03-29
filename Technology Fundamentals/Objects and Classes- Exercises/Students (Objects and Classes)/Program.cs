using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students__Objects_and_Classes_
{
    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] information = Console.ReadLine().Split();
                students.Add(new Student(information));
            }

            students.OrderByDescending(x => x.Grade).ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string[] information)
        {
            FirstName = information[0];
            LastName = information[1];
            Grade = double.Parse(information[2]);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
