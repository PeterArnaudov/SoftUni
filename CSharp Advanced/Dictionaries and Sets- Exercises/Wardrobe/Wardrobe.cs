namespace Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class Wardrobe
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string currentColour = input[0];
                string[] clothes = input[1].Split(',');

                if (!wardrobe.ContainsKey(currentColour))
                {
                    wardrobe.Add(currentColour, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[currentColour].ContainsKey(clothes[j]))
                    {
                        wardrobe[currentColour].Add(clothes[j], 0);
                    }

                    wardrobe[currentColour][clothes[j]]++;
                }
            }

            string[] itemWanted = Console.ReadLine().Split();
            string colour = itemWanted[0];
            string item = itemWanted[1];

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var clothing in kvp.Value)
                {
                    if (colour == kvp.Key && item == clothing.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                }
            }
        }
    }
}