using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Users
{
    public class Program
    {
        public static void Main()
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                if (input[0] == "End")
                {
                    break;
                }

                string company = input[0];
                string employee = input[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                if (!companies[company].Contains(employee))
                {
                    companies[company].Add(employee);
                }
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);

                foreach (var employee in companies[company.Key])
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}