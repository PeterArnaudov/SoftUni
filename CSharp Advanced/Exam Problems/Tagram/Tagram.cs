namespace Tagram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tagram
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string infomation = Console.ReadLine();

                if (infomation.Contains("end"))
                {
                    break;
                }
                else if (infomation.Contains("ban"))
                {
                    BanUser(users, infomation);
                }
                else
                {
                    ManageLikes(users, infomation);
                }
            }

            PrintOutput(users);
        }

        public static void ManageLikes(Dictionary<string, Dictionary<string, int>> users, string input)
        {
            string[] information = input.Split(" -> ");
            string user = information[0];
            string tag = information[1];
            int likes = int.Parse(information[2]);

            if (!users.ContainsKey(user))
            {
                users.Add(user, new Dictionary<string, int>());
            }

            if (!users[user].ContainsKey(tag))
            {
                users[user].Add(tag, 0);
            }

            users[user][tag] += likes;
        }

        public static void BanUser(Dictionary<string, Dictionary<string, int>> users, string input)
        {
            string[] information = input.Split();
            string user = information[1];

            users.Remove(user);
        }

        public static void PrintOutput(Dictionary<string, Dictionary<string, int>> users)
        {
            foreach (var user in users.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Values.Count))
            {
                Console.WriteLine(user.Key);
                foreach (var tag in user.Value)
                {
                    Console.WriteLine($"- {tag.Key}: {tag.Value}");
                }
            }
        }
    }
}
