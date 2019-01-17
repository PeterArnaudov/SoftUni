using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quests_Journal
{
    public class Program
    {
        public static void Main()
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split(" - ", ':');
                string command = commandLine[0];

                if (command == "Retire!")
                {
                    break;
                }
                else if (command == "Start")
                {
                    StartCommand(commandLine, journal);
                }
                else if (command == "Complete")
                {
                    CompleteCommand(commandLine, journal);
                }
                else if (command == "Side Quest")
                {
                    SideQuestCommand(commandLine, journal);
                }
                else if (command == "Renew")
                {
                    RenewCommand(commandLine, journal);
                }
            }

            Console.WriteLine(string.Join(", ", journal));
        }

        public static List<string> StartCommand(string[] commandLine, List<string> journal)
        {
            string quest = commandLine[1];

            if (!journal.Contains(quest))
            {
                journal.Add(quest);
            }

            return journal;
        }

        public static List<string> CompleteCommand(string[] commandLine, List<string> journal)
        {
            string quest = commandLine[1];

            if (journal.Contains(quest))
            {
                journal.Remove(quest);
            }

            return journal;
        }

        public static List<string> SideQuestCommand(string[] commandLine, List<string> journal)
        {
            string[] separated = commandLine[1].Split(':');

            string quest = separated[0];
            string sideQuest = separated[1];

            if (!journal.Contains(sideQuest))
            {
                if (journal.Contains(quest))
                {
                    int index = journal.FindIndex(x => x == quest);
                    journal.Insert(index + 1, sideQuest);
                }
            }

            return journal;
        }

        public static List<string> RenewCommand(string[] commandLine, List<string> journal)
        {
            string quest = commandLine[1];

            if (journal.Contains(quest))
            {
                journal.Remove(quest);
                journal.Add(quest);
            }

            return journal;
        }
    }
}
