using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Furniture
{
    public class Program
    {
        public static void Main()
        {
            string pattern = @">>(?<furniture>.+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
            double moneySpent = 0.0;
            List<string> bought = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Match valid = Regex.Match(input, pattern);

                if (valid.Value.Length > 0)
                {
                    bought.Add(valid.Groups["furniture"].Value);
                    moneySpent += double.Parse(valid.Groups["price"].Value) * int.Parse(valid.Groups["quantity"].Value);
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (var furniture in bought)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {moneySpent:f2}");
        }
    }
}
