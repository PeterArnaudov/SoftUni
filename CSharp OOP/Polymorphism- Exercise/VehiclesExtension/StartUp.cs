namespace VehiclesExtension
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] information = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(information[1]), double.Parse(information[2]), double.Parse(information[3]));

            information = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(information[1]), double.Parse(information[2]), double.Parse(information[3]));

            information = Console.ReadLine().Split();
            Bus bus = new Bus(double.Parse(information[1]), double.Parse(information[2]), double.Parse(information[3]));

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Refuel")
                {
                    try
                    {
                        if (command[1] == "Car")
                        {
                            car.Refuel(double.Parse(command[2]));
                        }
                        else if (command[1] == "Truck")
                        {
                            truck.Refuel(double.Parse(command[2]));
                        }
                        else if (command[1] == "Bus")
                        {
                            bus.Refuel(double.Parse(command[2]));
                        }
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                else if (command[0].Contains("Drive"))
                {
                    if (command[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(command[2])));
                    }
                    else if (command[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(command[2])));
                    }
                    else if (command[1] == "Bus")
                    {
                        if (command[0] == "Drive")
                        {
                            bus.TurnAirConditionerOn();
                            Console.WriteLine(bus.Drive(double.Parse(command[2])));
                        }
                        else if (command[0] == "DriveEmpty")
                        {
                            bus.TurnAirConditionerOff();
                            Console.WriteLine(bus.Drive(double.Parse(command[2])));
                        }
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
