using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    public class Program
    {
        public static void Main()
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string user = input[0];
                string teamName = input[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(x => x.Creator == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }

                teams.Add(CreateTeam(input));
                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] information = input.Split("->");
                string user = information[0];
                string teamName = information[1];

                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(x => x.Users.Contains(user)) || teams.Any(x => x.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                if (teams.Any(x => x.Name == teamName))
                {
                    Team existingTeam = teams.First(x => x.Name == teamName);
                    existingTeam.Users.Add(user);
                }
            }

            List<Team> disbanded = teams.Where(x => x.Users.Count == 0).ToList();
            teams = teams.Where(x => x.Users.Count > 0).ToList();

            foreach (var team in teams.OrderByDescending(x => x.Users.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");

                Console.WriteLine($"- {team.Creator}");

                foreach (var user in team.Users.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (var team in disbanded.OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }

        public static Team CreateTeam(string[] information)
        {
            string creator = information[0];
            string teamName = information[1];

            return new Team
            {
                Name = teamName,
                Creator = creator,
                Users = new List<string>()
            };
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Users { get; set; }
    }
}