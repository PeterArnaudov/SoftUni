namespace SpeedRacing
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] info = Console.ReadLine().Split();

                cars.Add(new Car(info[0], double.Parse(info[1]), double.Parse(info[2])));
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] commandArray = command.Split();

                Car driven = cars.Find(x => x.Model == commandArray[1]);
                driven.Drive(double.Parse(commandArray[2]));
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Traveled}");
            }
        }
    }
}
