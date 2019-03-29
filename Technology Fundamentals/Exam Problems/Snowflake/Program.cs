using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Snowflake
{
    public class Program
    {
        public static void Main()
        {
            string surfacePattern = @"[\dA-Za-z]+";
            string mantlePattern = @"[^\d_]+";
            string corePattern = @"[^a-zA-Z\d]+[\d_]+([a-zA-Z]+)[\d_]+[^a-zA-Z\d]+";

            List<string> parts = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                parts.Add(Console.ReadLine());
            }

            Match partOne = Regex.Match(parts[0], surfacePattern);
            Match partTwo = Regex.Match(parts[1], mantlePattern);
            Match partThree = Regex.Match(parts[2], corePattern);
            Match partFour = Regex.Match(parts[3], mantlePattern);
            Match partFive = Regex.Match(parts[4], surfacePattern);

            if (partOne.Value.Length > 0 || partTwo.Value.Length > 0 || partFour.Value.Length > 0 || partFive.Value.Length > 0)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
                Console.WriteLine(partThree.Groups[1].Value.Length);
            }
        }
    }
}
