using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Catalogue__Exercises_
{
    public class Program
    {
        public static void Main()
        {
            List<VehicleCatalogue> catalogue = new List<VehicleCatalogue>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] information = input.Split();

                string type = information[0];

                catalogue.Add(new VehicleCatalogue(information));
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                foreach (var vehicle in catalogue)
                {
                    if (vehicle.Model == input)
                    {
                        if (vehicle.Type == "car")
                        {
                            Console.WriteLine("Type: Car");
                        }
                        else
                        {
                            Console.WriteLine("Type: Truck");
                        }
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }
            }

            double avgCarsHorsepower = 0.0;
            double avgTrucksHorsepower = 0.0;

            if (catalogue.Where(x => x.Type == "car").ToList().Count > 0)
            {
                avgCarsHorsepower = catalogue.Where(x => x.Type == "car").Average(x => x.Horsepower);
            }

            if (catalogue.Where(x => x.Type == "truck").ToList().Count > 0)
            {
                avgTrucksHorsepower = catalogue.Where(x => x.Type == "truck").Average(x => x.Horsepower);
            }

            Console.WriteLine($"Cars have average horsepower of: {avgCarsHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTrucksHorsepower:f2}.");
        }

        public class VehicleCatalogue
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }

            public VehicleCatalogue(string[] information)
            {
                Type = information[0].ToLower();
                Model = information[1];
                Color = information[2];
                Horsepower = double.Parse(information[3]);
            }
        }
    }
}
