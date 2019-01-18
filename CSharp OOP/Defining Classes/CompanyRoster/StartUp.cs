namespace CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < number; i++)
            {
                string[] info = Console.ReadLine().Split();

                string email = "n/a";
                int age = -1;

                if (info.Length > 4)
                {
                    int parsed;
                    var isDigit = int.TryParse(info[4], out parsed);

                    if (isDigit)
                    {
                        age = parsed;
                    }
                    else
                    {
                        email = info[4];
                    }

                    if (info.Length > 5)
                    {
                        if (isDigit)
                        {
                            email = info[5];
                        }
                        else
                        {
                            age = int.Parse(info[5]);
                        }
                    }
                }

                employees.Add(new Employee(info[0], double.Parse(info[1]), info[2], info[3], email, age));
            }

            var highestSalaryDepartment = employees
                .GroupBy(x => x.Department)
                .OrderByDescending(x => x.Select(d => d.Salary).Sum())
                .First();

            Console.WriteLine($"Highest Average Salary: {highestSalaryDepartment.Key}");
            foreach (var employee in highestSalaryDepartment.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
