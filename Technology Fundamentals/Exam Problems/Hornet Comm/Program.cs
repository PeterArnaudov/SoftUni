using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_Comm
{
    public class Program
    {
        public static void Main()
        {
            //output resources:
            //messages:
            List<string> recipients = new List<string>();
            List<string> recipientsMessages = new List<string>();
            //broadcasts:
            List<string> frequency = new List<string>();
            List<string> frequencyMessages = new List<string>();

            while (true)
            {
                string data = Console.ReadLine();

                if (data == "Hornet is Green")
                {
                    break;
                }

                List<string> input = Regex.Split(data, " <-> ").ToList();

                if (input.Count() == 1)
                {
                    continue;
                }

                bool broadcast = false;
                bool message = false;
                bool isValid = true;

                for (int i = 0; i < input[0].Length; i++)
                {
                    bool isDigit = char.IsDigit(input[0][i]);

                    if (!isDigit)
                    {
                        message = false;
                        broadcast = true;
                        break;
                    }

                    message = true;
                }

                for (int i = 0; i < input[1].Length; i++)
                {
                    isValid = char.IsLetterOrDigit(input[1][i]);

                    if (!isValid)
                    {
                        break;
                    }
                }

                if (!isValid)
                {
                    continue;
                }

                if (message)
                {
                    string removed = string.Empty;
                    for (int i = 0; i < input[0].Length; i++)
                    {
                        removed += input[0][i];
                    }
                    input[0] = string.Empty;
                    for (int i = removed.Length - 1; i >= 0; i--)
                    {
                        input[0] += removed[i];
                    }

                    recipients.Add(input[0]);
                    recipientsMessages.Add(input[1]);
                }
                else if (broadcast)
                {
                    string newString = string.Empty;
                    for (int i = 0; i < input[1].Length; i++)
                    {
                        char removed = input[1][i];
                        if (char.IsLower(input[1][i]))
                        {
                            removed = char.ToUpper(removed);
                        }
                        else if (char.IsUpper(input[1][i]))
                        {
                            removed = char.ToLower(removed);
                        }
                        newString += removed;
                    }

                    input[1] = newString;
                    frequency.Add(input[1]);
                    frequencyMessages.Add(input[0]);
                }
            }

            Console.WriteLine("Broadcasts:");
            if (frequency.Count() == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < frequency.Count(); i++)
                {
                    Console.WriteLine($"{frequency[i]} -> {frequencyMessages[i]}");
                }
            }

            Console.WriteLine("Messages:");
            if (recipients.Count() == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < recipients.Count(); i++)
                {
                    Console.WriteLine($"{recipients[i]} -> {recipientsMessages[i]}");
                }
            }
        }
    }
}
