using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Challenger
{
    public class Program
    {
        public static void Main()
        {
            List<Player> players = new List<Player>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                if (input.Contains("vs"))
                {
                    string[] information = input.Split(" vs ");
                    string playerOne = information[0];
                    string playerTwo = information[1];

                    if (players.Any(x => x.Name == playerOne) && players.Any(x => x.Name == playerTwo))
                    {
                        int indexOne = players.FindIndex(x => x.Name == playerOne);
                        int indexTwo = players.FindIndex(x => x.Name == playerTwo);

                        foreach (var kvp in players[indexTwo].Positions)
                        {
                            if (players[indexOne].Positions.Any(x => x.Key == kvp.Key))
                            {
                                int totalSkillOne = players[indexOne].Positions.Values.Sum();
                                int totalSkillTwo = players[indexTwo].Positions.Values.Sum();

                                if (totalSkillOne > totalSkillTwo)
                                {
                                    players.RemoveAt(indexTwo);
                                }
                                else if (totalSkillTwo > totalSkillOne)
                                {
                                    players.RemoveAt(indexOne);
                                }

                                break;
                            }
                        }                        
                    }
                }
                else
                {
                    string[] information = input.Split(" -> ");
                    string name = information[0];
                    string position = information[1];
                    int skillPoints = int.Parse(information[2]);

                    Player newPlayer = new Player(name, position, skillPoints);

                    if (!players.Any(x => x.Name == name))
                    {
                        players.Add(newPlayer);
                    }
                    else
                    {
                        int index = players.FindIndex(x => x.Name == name);

                        if (!players[index].Positions.ContainsKey(position))
                        {
                            players[index].Positions.Add(position, skillPoints);
                        }
                        else
                        {
                            if (skillPoints > players[index].Positions[position])
                            {
                                players[index].Positions[position] = skillPoints;
                            }
                        }
                    }
                }
            }

            foreach (var player in players.OrderByDescending(x => x.Positions.Values.Sum()).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{player.Name}: {player.Positions.Values.Sum()} skill");
                foreach (var kvp in player.Positions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public Dictionary<string, int> Positions { get; set; }
        public int TotalSkill { get; set; }

        public Player(string name, string position, int skillPoints)
        {
            Name = name;
            Positions = new Dictionary<string, int>();
            Positions.Add(position, skillPoints);
        }
    }
}
