namespace PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandArray = command.Split();

                string action = commandArray[0];
                string conditionOne = commandArray[1];

                if (action == "Double")
                {
                    if (conditionOne == "StartsWith")
                    {
                        string conditionTwo = commandArray[2];
                        List<string> doubled = names.Where(x => x.StartsWith(conditionTwo)).ToList();
                        names = names.Concat(doubled).ToList();
                    }
                    else if (conditionOne == "EndsWith")
                    {
                        string conditionTwo = commandArray[2];
                        List<string> doubled = names.Where(x => x.EndsWith(conditionTwo)).ToList();
                        names = names.Concat(doubled).ToList();
                    }
                    else if (conditionOne == "Length")
                    {
                        int conditionTwo = int.Parse(commandArray[2]);
                        List<string> doubled = names.Where(x => x.Length == conditionTwo).ToList();
                        names = names.Concat(doubled).ToList();
                    }
                }
                else if (action == "Remove")
                {
                    if (conditionOne == "StartsWith")
                    {
                        string conditionTwo = commandArray[2];
                        names.RemoveAll(x => x.StartsWith(conditionTwo));
                    }
                    else if (conditionOne == "EndsWith")
                    {
                        string conditionTwo = commandArray[2];
                        names.RemoveAll(x => x.EndsWith(conditionTwo));
                    }
                    else if (conditionOne == "Length")
                    {
                        int conditionTwo = int.Parse(commandArray[2]);
                        names.RemoveAll(x => x.Length == conditionTwo);
                    }
                }

                command = Console.ReadLine();
            }

            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
        }
    }
}
