namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Team> teams = new List<Team>();

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split(';');

                if (commandLine[0] == "END")
                {
                    break;
                }
                else if (commandLine[0] == "Team")
                {
                    teams.Add(new Team(commandLine[1]));
                }
                else
                {
                    Team team = teams.Find(t => t.Name == commandLine[1]);

                    if (team == null)
                    {
                        Console.WriteLine($"Team {commandLine[1]} does not exist.");
                        continue;
                    }

                    try
                    {
                        if (commandLine[0] == "Add")
                        {
                            team.AddPlayer(new Player(commandLine[2], double.Parse(commandLine[3]),
                            double.Parse(commandLine[4]), double.Parse(commandLine[5]), double.Parse(commandLine[6]), double.Parse(commandLine[7])));
                        }
                        else if (commandLine[0] == "Remove")
                        {
                            team.RemovePlayer(commandLine[2]);
                        }
                        else if (commandLine[0] == "Rating")
                        {
                            team.PrintRating();
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
