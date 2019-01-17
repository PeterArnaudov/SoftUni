namespace TheVLogger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TheVLogger
    {
        public static void Main()
        {
            List<Vlogger> vloggers = new List<Vlogger>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }
                else if (input.Contains("joined"))
                {
                    string[] info = input.Split();
                    string name = info[0];

                    if (!vloggers.Any(x => x.Name == name))
                    {
                        vloggers.Add(new Vlogger(name));
                    }
                }
                else if (input.Contains("followed"))
                {
                    string[] info = input.Split();
                    string follower = info[0];
                    string followed = info[2];

                    if (follower == followed || !vloggers.Any(x => x.Name == follower) || !vloggers.Any(x => x.Name == followed))
                    {
                        continue;
                    }

                    int index = vloggers.FindIndex(x => x.Name == follower);
                    vloggers[index].Following.Add(followed);

                    index = vloggers.FindIndex(x => x.Name == followed);
                    vloggers[index].Followers.Add(follower);
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            vloggers = vloggers.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Following.Count).ToList();

            Console.WriteLine($"1. {vloggers[0].Name} : {vloggers[0].Followers.Count} followers, {vloggers[0].Following.Count} following");
            foreach (var follower in vloggers[0].Followers)
            {
                Console.WriteLine($"*  {follower}");
            }

            for (int i = 1; i < vloggers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vloggers[i].Name} : {vloggers[i].Followers.Count} followers, {vloggers[i].Following.Count} following");
            }
        }
    }

    public class Vlogger
    {
        public string Name { get; set; }

        public SortedSet<string> Followers { get; set; }

        public HashSet<string> Following { get; set; }

        public Vlogger(string name)
        {
            Name = name;
            Followers = new SortedSet<string>();
            Following = new HashSet<string>();
        }
    }
}
