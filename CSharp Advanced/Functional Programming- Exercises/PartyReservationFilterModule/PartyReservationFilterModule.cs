namespace PartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PartyReservationFilterModule
    {
        public static void Main()
        {
            string[] names = Console.ReadLine().Split();
            List<string> going = new List<string>(names);

            string command = Console.ReadLine();

            while (command != "Print")
            {
                string[] commandArray = command.Split(';');

                ForEach(names, going, commandArray);

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", going));
        }

        public static void ForEach(string[] names, List<string> going, string[] commandArray)
        {
            if (commandArray[0] == "Add filter")
            {
                if (commandArray[1] == "Starts with")
                {
                    List<string> remove = going.Where(x => x.StartsWith(commandArray[2])).ToList();

                    foreach (var name in remove)
                    {
                        going.Remove(name);
                    }
                }
                else if (commandArray[1] == "Ends with")
                {
                    List<string> remove = going.Where(x => x.EndsWith(commandArray[2])).ToList();

                    foreach (var name in remove)
                    {
                        going.Remove(name);
                    }
                }
                else if (commandArray[1] == "Contains")
                {
                    List<string> remove = going.Where(x => x.Contains(commandArray[2])).ToList();

                    foreach (var name in remove)
                    {
                        going.Remove(name);
                    }
                }
                else if (commandArray[1] == "Length")
                {
                    List<string> remove = going.Where(x => x.Length == int.Parse(commandArray[2])).ToList();

                    foreach (var name in remove)
                    {
                        going.Remove(name);
                    }
                }
            }
            else if (commandArray[0] == "Remove filter")
            {
                if (commandArray[1] == "Starts with")
                {
                    List<string> add = names.Where(x => x.StartsWith(commandArray[2])).ToList();

                    foreach (var name in add)
                    {
                        going.Add(name);
                    }
                }
                else if (commandArray[1] == "Ends with")
                {
                    List<string> add = names.Where(x => x.EndsWith(commandArray[2])).ToList();

                    foreach (var name in add)
                    {
                        going.Add(name);
                    }
                }
                else if (commandArray[1] == "Contains")
                {
                    List<string> add = names.Where(x => x.Contains(commandArray[2])).ToList();

                    foreach (var name in add)
                    {
                        going.Add(name);
                    }
                }
                else if (commandArray[1] == "Length")
                {
                    List<string> add = names.Where(x => x.Length == int.Parse(commandArray[2])).ToList();

                    foreach (var name in add)
                    {
                        going.Add(name);
                    }
                }
            }
        }
    }
}
