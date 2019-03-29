using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> forceUsers = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains("|"))
                {
                    string[] data = input.Split(" | ");
                    string forceSide = data[0];
                    string forceUser = data[1];
                    bool exists = false;

                    foreach (var side in forceUsers)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        if (!forceUsers.ContainsKey(forceSide))
                        {
                            forceUsers.Add(forceSide, new List<string>());
                        }

                        forceUsers[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] data = input.Split(" -> ");
                    string forceUser = data[0];
                    string forceSide = data[1];
                    bool exists = false;
                    string pastSide = string.Empty;

                    foreach (var side in forceUsers)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            exists = true;
                            pastSide = side.Key;
                            break;
                        }
                    }

                    if (exists)
                    {
                        if (!forceUsers.ContainsKey(forceSide))
                        {
                            forceUsers.Add(forceSide, new List<string>());
                        }

                        forceUsers[pastSide].Remove(forceUser);
                        forceUsers[forceSide].Add(forceUser);
                    }
                    else if (!exists)
                    {
                        if (!forceUsers.ContainsKey(forceSide))
                        {
                            forceUsers.Add(forceSide, new List<string>());
                        }

                        forceUsers[forceSide].Add(forceUser);
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            foreach (var side in forceUsers.OrderByDescending(x => forceUsers[x.Key].Count).ThenBy(x => x.Key))
            {
                if (forceUsers[side.Key].Count == 0)
                {
                    continue;
                }
                Console.WriteLine($"Side: {side.Key}, Members: {forceUsers[side.Key].Count}");

                foreach (var user in forceUsers[side.Key].OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}