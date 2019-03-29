using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Catalogue
{
    public class Program
    {
        public static void Main()
        {
            VehicleCatalogue catalogue = new VehicleCatalogue()
            {
                Cars = new List<Car>(),
                Trucks = new List<Truck>()
            };

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] information = input.Split('/');
                string type = information[0];

                if (type == "Truck")
                {
                    catalogue.Trucks.Add(AddTruck(information));
                }
                else if (type == "Car")
                {
                    catalogue.Cars.Add(AddCar(information));
                }
            }

            Console.WriteLine("Cars:");
            foreach (var car in catalogue.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (var truck in catalogue.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }

        public static Truck AddTruck(string[] information)
        {
            return new Truck
            {
                Brand = information[1],
                Model = information[2],
                Weight = int.Parse(information[3])
            };
        }

        public static Car AddCar(string[] information)
        {
            return new Car
            {
                Brand = information[1],
                Model = information[2],
                HorsePower = int.Parse(information[3])
            };
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class VehicleCatalogue
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
