using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Counter
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> countriesAndCities = new Dictionary<string, Dictionary<string, long>>(); //countries and cities
            Dictionary<string, long> countries = new Dictionary<string, long>(); //total population for each country

            while (true)
            {
                string[] input = Console.ReadLine().Split('|');
                string city = input[0];

                if (city == "report")
                {
                    break;
                }

                string country = input[1];
                long population = long.Parse(input[2]);

                if (!countriesAndCities.ContainsKey(country))
                {
                    countriesAndCities.Add(country, new Dictionary<string, long>());
                    countries.Add(country, 0);
                }

                if (!countriesAndCities[country].ContainsKey(city))
                {
                    countriesAndCities[country].Add(city, 0);
                }

                countriesAndCities[country][city] += population;
                countries[country] += population;
            }

            countries = countries.OrderByDescending(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var country in countries)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                foreach (var city in countriesAndCities[country.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}