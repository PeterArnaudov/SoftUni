namespace Concert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> bandsMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandsTime = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();
                string[] separators = new string[] { "; ", ", " };

                if (command == "start of concert")
                {
                    break;
                }

                string[] commandArray = command.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (commandArray[0] == "Add")
                {
                    string name = commandArray[1];
                    List<string> members = new List<string>();

                    for (int i = 2; i < commandArray.Length; i++)
                    {
                        members.Add(commandArray[i]);
                    }

                    if (!bandsMembers.Any(x => x.Key == name))
                    {
                        bandsMembers.Add(name, new List<string>());
                        bandsTime.Add(name, 0);
                    }

                    for (int i = 0; i < members.Count; i++)
                    {
                        if (!bandsMembers[name].Any(x => x == members[i]))
                        {
                            bandsMembers[name].Add(members[i]);
                        }
                    }
                }
                else if (commandArray[0] == "Play")
                {
                    string name = commandArray[1];
                    int time = int.Parse(commandArray[2]);

                    if (!bandsMembers.Any(x => x.Key == name))
                    {
                        bandsMembers.Add(name, new List<string>());
                        bandsTime.Add(name, 0);
                    }

                    bandsTime[name] += time;
                }
            }

            int totalTime = bandsTime.Values.Sum();

            Console.WriteLine($"Total time: {totalTime}");
            foreach (var kvp in bandsTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                foreach (var member in bandsMembers[kvp.Key].OrderBy(x => x))
                {
                    Console.WriteLine($"=> {member}");
                }
            }
        }
    }
}
