using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ");

                if (input[0] == "end")
                {
                    break;
                }

                string course = input[0];
                string student = input[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }

                courses[course].Add(student);
            }

            foreach (var course in courses.OrderByDescending(x => courses[x.Key].Count))
            {
                Console.WriteLine($"{course.Key}: {courses[course.Key].Count}");
                foreach (var student in courses[course.Key].OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}