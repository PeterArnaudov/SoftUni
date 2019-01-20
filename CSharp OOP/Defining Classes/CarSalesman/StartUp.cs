namespace CarSalesman
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] info = Console.ReadLine().Split();
                engines.Add(CreateEngine(info));
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] info = Console.ReadLine().Split();
                cars.Add(CreateCar(info, engines));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static Engine CreateEngine(string[] info)
        {
            Engine engine = new Engine(info[0], int.Parse(info[1]));

            if (info.Length > 2)
            {
                var IsDigit = int.TryParse(info[2], out int displacement);

                if (IsDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = info[2];
                }

                if (info.Length > 3)
                {
                    engine.Efficiency = info[3];
                }
            }

            return engine;
        }

        public static Car CreateCar(string[] info, List<Engine> engines)
        {
            Engine engine = engines.Find(x => x.Model == info[1]);
            Car car = new Car(info[0], engine);

            if (info.Length > 2)
            {
                var isDigit = int.TryParse(info[2], out int weight);

                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = info[2];
                }

                if (info.Length > 3)
                {
                    car.Color = info[3];
                }
            }

            return car;
        }
    }
}
