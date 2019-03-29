namespace AutoRepairAndService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AutoRepairAndService
    {
        public static void Main()
        {
            string[] carsArray = Console.ReadLine().Split();

            Queue<string> awaitingCars = new Queue<string>(carsArray);
            Stack<string> servedCars = new Stack<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Service" && awaitingCars.Any())
                {
                    servedCars.Push(awaitingCars.Peek());
                    Console.WriteLine($"Vehicle {awaitingCars.Dequeue()} got served.");
                }
                else if (command.Contains("CarInfo"))
                {
                    string[] commandArray = command.Split('-');

                    if (awaitingCars.Contains(commandArray[1]))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }

                command = Console.ReadLine();
            }

            if (awaitingCars.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", awaitingCars)}");
            }

            if (servedCars.Any())
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
            }
        }
    }
}
