using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            Dictionary<string, double> departments = new Dictionary<string, double>();

            for (int i = 0; i < number; i++)
            {
                string[] information = Console.ReadLine().Split();

                Employee newEmployee = new Employee(information);
                employees.Add(newEmployee);

                string department = newEmployee.Department;
                double salary = newEmployee.Salary;

                if (!departments.ContainsKey(department))
                {
                    departments.Add(department, salary);
                }
                else
                {
                    departments[department] += salary;
                }
            }

            departments = departments.OrderByDescending(x => x.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            string bestDep = string.Empty;

            foreach (var dep in departments)
            {
                bestDep = dep.Key;
                break;
            }

            Console.WriteLine($"Highest Average Salary: {bestDep}");

            foreach (var employee in employees.Where(x => x.Department == bestDep).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(string[] information)
        {
            Name = information[0];
            Salary = double.Parse(information[1]);
            Department = information[2];
        }
    }
}
