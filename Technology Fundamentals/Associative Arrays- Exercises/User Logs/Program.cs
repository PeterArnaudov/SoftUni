using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logs
{
    public class Program
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> usersAndIps = new SortedDictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputLine = input.Split('=', ' ');

                string ip = inputLine[1];
                string user = inputLine[5];

                if (!usersAndIps.ContainsKey(user))
                {
                    usersAndIps.Add(user, new Dictionary<string, int>());
                    usersAndIps[user].Add(ip, 1);
                }
                else if (!usersAndIps[user].ContainsKey(ip))
                {
                    usersAndIps[user].Add(ip, 1);
                }
                else
                {
                    usersAndIps[user][ip]++;
                }
            }

            foreach (var user in usersAndIps)
            {
                Console.WriteLine($"{user.Key}:");
                int count = user.Value.Count;
                int current = 0;

                foreach (var ip in user.Value)
                {
                    current++;

                    if (current < count)
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}. ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
