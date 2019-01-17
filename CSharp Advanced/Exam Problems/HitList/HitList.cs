namespace HitList
{
    using System;
    using System.Collections.Generic;

    public class HitList
    {
        public static void Main()
        {
            int infoIndex = int.Parse(Console.ReadLine());

            Dictionary<string, SortedDictionary<string, string>> people = new Dictionary<string, SortedDictionary<string, string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end transmissions")
                {
                    break;
                }

                string[] info = input.Split('=', ':', ';');

                string name = info[0];

                if (!people.ContainsKey(name))
                {
                    people.Add(name, new SortedDictionary<string, string>());
                }

                for (int i = 1; i < info.Length; i+=2)
                {
                    string key = info[i];
                    string value = info[i + 1];

                    if (!people[name].ContainsKey(key))
                    {
                        people[name].Add(key, value);
                    }
                    else
                    {
                        people[name][key] = value;
                    }
                }
            }

            string[] kill = Console.ReadLine().Split();
            string killName = kill[1];
            int killInfoIndex = 0;

            Console.WriteLine($"Info on {killName}:");

            foreach (var info in people[killName])
            {
                Console.WriteLine($"---{info.Key}: {info.Value}");
                killInfoIndex += info.Key.Length;
                killInfoIndex += info.Value.Length;
            }

            Console.WriteLine($"Info index: {killInfoIndex}");

            if (infoIndex <= killInfoIndex)
            {
                Console.WriteLine($"Proceed");
            }
            else
            {
                Console.WriteLine($"Need {infoIndex - killInfoIndex} more info.");
            }
        }
    }
}
