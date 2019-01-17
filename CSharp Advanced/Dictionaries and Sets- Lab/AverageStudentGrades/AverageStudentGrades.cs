namespace AverageStudentGrades
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }

                students[name].Add(grade);
            }

            foreach (var kvp in students)
            {
                Console.Write($"{kvp.Key} -> ");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
