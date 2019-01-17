using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Party
{
    public class Program
    {
        public static void Main()
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[2] == "going!")
                {
                    if (!guests.Contains(command[0]))
                    {
                        guests.Add(command[0]);
                        continue; ;
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                        continue; ;
                    }
                }
                else if (command[2] == "not")
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                        continue;
                    }
                }
            }

            foreach (var name in guests)
            {
                Console.WriteLine(name);
            }
        }
    }
}
