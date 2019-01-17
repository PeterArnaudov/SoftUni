using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    public class Program
    {
        public static void Main()
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> valid = new List<string>();

            string pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length == 20)
                {
                    string left = string.Empty;
                    string right = string.Empty;

                    for (int j = 0; j < 10; j++)
                    {
                        left += tickets[i][j];
                    }
                    for (int k = 10; k < 20; k++)
                    {
                        right += tickets[i][k];
                    }

                    MatchCollection leftMatch = regex.Matches(left);
                    MatchCollection rightMatch = regex.Matches(right);

                    int count = leftMatch.Count + rightMatch.Count;

                    if (count < 2)
                    {
                        Console.WriteLine($"ticket {(char)34}{tickets[i]}{(char)34} - no match");
                    }
                    else if (leftMatch[0].Length == 10 && rightMatch[0].Length == 10 && count == 2)
                    {
                        Console.WriteLine($"ticket {(char)34}{tickets[i]}{(char)34} - {leftMatch[0].Length}{leftMatch[0].ToString().First()} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket {(char)34}{tickets[i]}{(char)34} - {Math.Min(leftMatch[0].Length, rightMatch[0].Length)}{leftMatch[0].ToString().First()}");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
