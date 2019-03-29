using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades
{
    public class Program
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                students.Add(ReadStudent());
            }

            students = students.Where(x => x.AverageGrade >= 5.00).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

            for (int i = 0; i < students.Count; i++)
            {
                PrintStudent(students[i]);
            }
        }

        public static Student ReadStudent()
        {
            string[] information = Console.ReadLine().Split();
            string name = information[0];
            List<double> grades = new List<double>();

            for (int i = 1; i < information.Length; i++)
            {
                double grade = double.Parse(information[i]);
                grades.Add(grade);
            }

            return new Student
            {
                Name = name,
                Grades = grades,
                AverageGrade = grades.Average()
            };
        }

        public static void PrintStudent(Student student)
        {
            string information = $"{student.Name} -> {student.AverageGrade:f2}";
            Console.WriteLine(information);
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }
    }
}
