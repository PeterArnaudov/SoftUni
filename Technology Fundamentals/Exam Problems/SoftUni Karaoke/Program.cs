using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUni_Karaoke
{
    public class Program
    {
        public static void Main()
        {
            string[] participants = Regex.Split(Console.ReadLine(), ", ");
            string[] songs = Regex.Split(Console.ReadLine(), ", ");
            Dictionary<string, List<string>> rewards = new Dictionary<string, List<string>>();
            Dictionary<string, int> rewardsCount = new Dictionary<string, int>();

            while (true)
            {
                string[] performance = Regex.Split(Console.ReadLine(), ", ");

                string participant = performance[0];

                if (participant == "dawn")
                {
                    break;
                }

                string song = performance[1];
                string reward = performance[2];

                if (!rewards.ContainsKey(participant) && songs.Contains(song) && participants.Contains(participant))
                {
                    rewards.Add(participant, new List<string>());
                    rewardsCount.Add(participant, 0);

                    rewards[participant].Add(reward);
                    rewardsCount[participant]++;

                }
                else if (rewards.ContainsKey(participant) && songs.Contains(song) && participants.Contains(participant) && !rewards[participant].Contains(reward))
                {

                    rewards[participant].Add(reward);
                    rewardsCount[participant]++;
                }
                else
                {
                    continue;
                }

            }

            if (rewardsCount.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var participant in rewardsCount.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value} awards");

                rewards[participant.Key].Sort();

                for (int i = 0; i < rewards[participant.Key].Count; i++)
                {
                    Console.WriteLine($"--{rewards[participant.Key][i]}");
                }
            }
        }
    }
}
