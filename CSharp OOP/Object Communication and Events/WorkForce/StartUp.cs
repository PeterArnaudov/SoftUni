namespace WorkForce
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            JobList jobs = new JobList();
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }
                else if (input[0] == "Job")
                {
                    Employee employee = employees.Find(e => e.Name == input[3]);
                    jobs.AddJob(new Job(employee, int.Parse(input[2]), input[1]));
                }
                else if (input[0] == "StandardEmployee")
                {
                    StandardEmployee employee = new StandardEmployee(input[1]);
                    employees.Add(employee);
                }
                else if (input[0] == "PartTimeEmployee")
                {
                    PartTimeEmployee employee = new PartTimeEmployee(input[1]);
                    employees.Add(employee);
                }
                else if (input[0] == "Pass")
                {
                    jobs.ToList().ForEach(j => j.Update());
                }
                else if (input[0] == "Status")
                {
                    jobs.ForEach(Console.WriteLine);
                }
            }
        }
    }
}
