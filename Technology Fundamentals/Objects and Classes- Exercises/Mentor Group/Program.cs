using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Mentor_Group
{ //beginning
    public class Program
    { //beginning of class Program
        public static void Main()
        { //beginning method Main
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of dates")
                {
                    break;
                }

                string[] information = input.Split(' ', ',');

                Student entry = ReadStudent(information);

                if (!students.Any(x => x.Name == entry.Name))
                {
                    students.Add(entry);

                    foreach (var student in students)
                    {
                        student.AddDates(information);
                    }
                }
                else
                {
                    foreach (var student in students)
                    {
                        student.AddDates(information);
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of comments")
                {
                    break;
                }

                string[] information = input.Split('-');

                foreach (var student in students)
                {
                    student.AddComments(information);
                }
            }

            foreach (var student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);

                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.Day:d2}/{date.Month:d2}/{date.Year}");
                }
            }
        } //end method Main

        public static Student ReadStudent(string[] information)
        {
            string name = information[0];

            return new Student
            {
                Name = name,
                Dates = new List<DateTime>(),
                Comments = new List<string>()
            };
        }
    } //end of class Program

    public class Student
    { //beginning of class Student
        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }

        public void AddDates(string[] information)
        { //beginning of AddDates method
            string name = information[0];

            if (Name == name)
            {
                for (int i = 1; i < information.Length; i++)
                {
                    DateTime date = DateTime.ParseExact(information[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Dates.Add(date);
                }
            }
        } //end of AddDates method

        public void AddComments(string[] information)
        { //beginning of AddComments method
            string name = information[0];
            string comment = information[1];

            if (Name == name)
            {
                Comments.Add(comment);
            }
        } //end of AddComments method
    } //end of class Student
} //end