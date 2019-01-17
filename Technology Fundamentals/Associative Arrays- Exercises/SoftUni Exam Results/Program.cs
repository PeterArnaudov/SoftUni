using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('-');

                if (input[0] == "exam finished")
                {
                    break;
                }

                if (input[1] == "banned")
                {
                    string username = input[0];

                    results.Remove(username);
                }
                else
                {
                    string username = input[0];
                    string language = input[1];
                    int points = int.Parse(input[2]);

                    if (!results.ContainsKey(username))
                    {
                        results.Add(username, points);
                    }
                    else
                    {
                        if (results[username] < points)
                        {
                            results[username] = points;
                        }
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;
                }
            }

            Console.WriteLine("Results:");
            foreach (var user in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var lang in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}
