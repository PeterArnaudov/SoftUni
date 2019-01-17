using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Upgrade
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }
                else if (command.Length == 2)
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                else if (command.Length == 3)
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        phonebook[command[1]] = command[2];
                    }
                    else
                    {
                        phonebook.Add(command[1], command[2]);
                    }
                }
                else if (command[0] == "ListAll")
                {
                    SortedDictionary<string, string> sortedPhonebook = new SortedDictionary<string, string>(phonebook);

                    foreach (var contact in sortedPhonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
            }
        }
    }
}