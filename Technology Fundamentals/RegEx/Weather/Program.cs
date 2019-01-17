using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Weather
{
    public class Program
    {
        public static void Main()
        {
            string pattern = @"([A-Z]{2})([\d]+\.[\d]+)([a-zA-Z]+)\|";
            List<City> cities = new List<City>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                Match matched = Regex.Match(input, pattern);

                if (matched.Value.Length > 0)
                {
                    string name = matched.Groups[1].Value;
                    double temperature = double.Parse(matched.Groups[2].Value);
                    string type = matched.Groups[3].Value;

                    City currentCity = new City(name, temperature, type);

                    if (!cities.Any(x => x.Name == currentCity.Name))
                    {
                        cities.Add(currentCity);
                    }
                    else
                    {
                        foreach (var city in cities)
                        {
                            if (city.Name == currentCity.Name)
                            {
                                city.Temperature = currentCity.Temperature;
                                city.Type = currentCity.Type;
                                break;
                            }
                        }
                    }
                }
            }

            foreach (var city in cities.OrderBy(x => x.Temperature))
            {
                Console.WriteLine($"{city.Name} => {city.Temperature:f2} => {city.Type}");
            }
        }
    }

    public class City
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        public string Type { get; set; }

        public City(string name, double temperature, string type)
        {
            Name = name;
            Temperature = temperature;
            Type = type;
        }
    }
}