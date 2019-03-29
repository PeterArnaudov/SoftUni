using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Race
{
    public class Program
    {
        public static void Main()
        {
            List<Racer> racers = new List<Racer>();

            string[] racersInput = Console.ReadLine().Split(", ");

            foreach (var racer in racersInput)
            {
                racers.Add(new Racer(racer, 0));
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }

                string currentName = string.Empty;
                int currentDistance = 0;

                MatchCollection letters = Regex.Matches(input, @"[a-zA-Z]");
                MatchCollection digits = Regex.Matches(input, @"\d");

                foreach (Match letter in letters)
                {
                    currentName += letter.Value;
                }

                foreach (Match digit in digits)
                {
                    currentDistance += int.Parse(digit.Value);
                }

                if (racers.Any(x => x.Name == currentName))
                {
                    for (int i = 0; i < racers.Count; i++)
                    {
                        if (currentName == racers[i].Name)
                        {
                            racers[i].Distance += currentDistance;
                        }
                    }
                }
            }

            racers = racers.OrderByDescending(x => x.Distance).Take(3).ToList();
            
            Console.WriteLine($"1st place: {racers[0].Name}");
            Console.WriteLine($"2nd place: {racers[1].Name}");
            Console.WriteLine($"3rd place: {racers[2].Name}");
        }
    }

    public class Racer
    {
        public string Name { get; set; }
        public int Distance { get; set; }

        public Racer(string name, int distance)
        {
            Name = name;
            Distance = distance;
        }
    }
}
