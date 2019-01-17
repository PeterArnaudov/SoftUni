using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_Grider
{
    public class Program
    {
        public static void Main()
        {
            List<Town> towns = new List<Town>();
            string[] separators = new string[] { "->", ":" };

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Slide rule")
                {
                    break;
                }

                if (input.Contains("ambush"))
                {
                    string[] information = input.Split(separators, StringSplitOptions.None);

                    string name = information[0];
                    int passengers = int.Parse(information[2]);

                    if (towns.Any(x => x.Name == name))
                    {
                        foreach (var town in towns)
                        {
                            if (town.Name == name)
                            {
                                town.Passengers -= passengers;
                                town.Time = 0;

                                break;
                            }
                        }
                    }
                    else
                    {
                        towns.Add(new Town(name, 0, 0));
                    }
                }
                else
                {
                    string[] information = input.Split(separators, StringSplitOptions.None);

                    string name = information[0];
                    int time = int.Parse(information[1]);
                    int passengers = int.Parse(information[2]);

                    if (towns.Any(x => x.Name == name))
                    {
                        foreach (var town in towns)
                        {
                            if (town.Name == name)
                            {
                                town.Passengers += passengers;

                                if (town.Time > time || town.Time == 0)
                                {
                                    town.Time = time;
                                }

                                break;
                            }
                        }
                    }
                    else
                    {
                        towns.Add(new Town(name, passengers, time));
                    }
                }
            }

            foreach (var town in towns.OrderBy(x => x.Time).ThenBy(x => x.Name))
            {
                if (town.Time != 0 && town.Passengers >= 0)
                {
                    Console.WriteLine($"{town.Name} -> Time: {town.Time} -> Passengers: {town.Passengers}");
                }
            }
        }
    }

    public class Town
    {
        public string Name { get; set; }
        public int Passengers { get; set; }
        public int Time { get; set; }

        public Town(string name, int passengers, int time)
        {
            Name = name;
            Passengers = passengers;
            Time = time;
        }
    }
}
