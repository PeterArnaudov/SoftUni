namespace CubicAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CubicAssault
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> regions = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Count em all")
                {
                    break;
                }

                string[] info = input.Split(" -> ");

                string regionName = info[0];
                string meteorType = info[1];
                int meteorQuantity = int.Parse(info[2]);

                if (!regions.ContainsKey(regionName))
                {
                    regions.Add(regionName, new Dictionary<string, long>());
                    regions[regionName].Add("Green", 0);
                    regions[regionName].Add("Red", 0);
                    regions[regionName].Add("Black", 0);
                }

                regions[regionName][meteorType] += meteorQuantity;

                bool transformed = false;

                while (!transformed)
                {
                    if (regions[regionName]["Green"] >= 1_000_000)
                    {
                        regions[regionName]["Green"] -= 1_000_000;
                        regions[regionName]["Red"]++;
                    }
                    else if (regions[regionName]["Red"] >= 1_000_000)
                    {
                        regions[regionName]["Red"] -= 1_000_000;
                        regions[regionName]["Black"]++;
                    }
                    else
                    {
                        transformed = true;
                    }
                }
            }

            foreach (var region in regions.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{region.Key}");
                foreach (var type in region.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"-> {type.Key} : {type.Value}");
                }
            }
        }
    }
}
