using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs_Aggregator
{
    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                string ip = input[0];
                string username = input[1];
                int duration = int.Parse(input[2]);

                if (!users.ContainsKey(username))
                {
                    users.Add(username, new Dictionary<string, int>());
                }

                if (!users[username].ContainsKey(ip))
                {
                    users[username].Add(ip, 0);
                }

                users[username][ip] += duration;
            }

            foreach (var user in users)
            {
                Console.Write($"{user.Key}: ");
                int totalDuration = 0;
                int current = 0;

                foreach (var ip in users[user.Key])
                {
                    totalDuration += ip.Value; //users[user.Key][ip.Key];
                }

                Console.Write(totalDuration + " [");

                foreach (var ip in users[user.Key].OrderBy(x => x.Key))
                {
                    current++;
                    if (current > users[user.Key].Count - 1)
                    {
                        Console.Write($"{ip.Key}]");
                        break;
                    }
                    Console.Write($"{ip.Key}, ");

                }

                Console.WriteLine();
            }
        }
    }
}