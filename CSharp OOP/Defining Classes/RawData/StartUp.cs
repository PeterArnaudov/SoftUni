namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < number; i++)
            {
                string[] info = Console.ReadLine().Split();

                Engine engine = new Engine(int.Parse(info[1]), int.Parse(info[2]));
                Cargo cargo = new Cargo(int.Parse(info[3]), info[4]);
                Tire[] tires = new Tire[]
                {
                    new Tire(double.Parse(info[5]), int.Parse(info[6])),
                    new Tire(double.Parse(info[7]), int.Parse(info[8])),
                    new Tire(double.Parse(info[9]), int.Parse(info[10])),
                    new Tire(double.Parse(info[11]), int.Parse(info[12]))
                };

                cars.Add(new Car(info[0], engine, cargo, tires));
            }

            string type = Console.ReadLine();
            List<Car> filtered = new List<Car>();

            if (type == "fragile")
            {
                filtered = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else if (type == "flamable")
            {
                filtered = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();
            }

            foreach (var car in filtered)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
