using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Chore_Wars
{
    public class Program
    {
        public static void Main()
        {
            string dishesPattern = @"<[a-z\d]+>";
            string cleaningPattern = @"\[[A-Z\d]+]";
            string laundryPattern = @"{.+}";
            string numbersPattern = @"\d";

            int dishesTime = 0;
            int cleaningTime = 0;
            int laundryTime = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "wife is happy")
                {
                    break;
                }

                Match dishesMatch = Regex.Match(input, dishesPattern);
                Match cleaningMatch = Regex.Match(input, cleaningPattern);
                Match laundryMatch = Regex.Match(input, laundryPattern);

                if (dishesMatch.Value.Length > 0)
                {
                    MatchCollection numbers = Regex.Matches(dishesMatch.Value, numbersPattern);

                    foreach (Match number in numbers)
                    {
                        dishesTime += int.Parse(number.Value);
                    }
                }
                else if (cleaningMatch.Value.Length > 0)
                {
                    MatchCollection numbers = Regex.Matches(cleaningMatch.Value, numbersPattern);

                    foreach (Match number in numbers)
                    {
                        cleaningTime += int.Parse(number.Value);
                    }
                }
                else if (laundryMatch.Value.Length > 0)
                {
                    MatchCollection numbers = Regex.Matches(laundryMatch.Value, numbersPattern);

                    foreach (Match number in numbers)
                    {
                        laundryTime += int.Parse(number.Value);
                    }
                }
            }

            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the house - {cleaningTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            Console.WriteLine($"Total - {dishesTime + cleaningTime + laundryTime} min.");
        }
    }
}
