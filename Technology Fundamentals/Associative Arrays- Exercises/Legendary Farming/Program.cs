using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legendary_Farming
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();
                List<string> materials = new List<string>();
                List<int> quantities = new List<int>();
                bool obtained = false;

                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantities.Add(int.Parse(input[i]));
                    }
                    else
                    {
                        materials.Add(input[i]);
                    }
                }

                for (int i = 0; i < materials.Count; i++)
                {
                    if (keyMaterials.ContainsKey(materials[i]))
                    {
                        keyMaterials[materials[i]] += quantities[i];
                    }
                    else if (!junk.ContainsKey(materials[i]))
                    {
                        junk.Add(materials[i], quantities[i]);
                    }
                    else if (junk.ContainsKey(materials[i]))
                    {
                        junk[materials[i]] += quantities[i];
                    }

                    if (keyMaterials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        keyMaterials["shards"] -= 250;
                        obtained = true;
                        break;
                    }
                    else if (keyMaterials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        keyMaterials["fragments"] -= 250;
                        obtained = true;
                        break;
                    }
                    else if (keyMaterials["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        keyMaterials["motes"] -= 250;
                        obtained = true;
                        break;
                    }
                }

                if (obtained)
                {
                    break;
                }
            }

            foreach (var material in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var material in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}