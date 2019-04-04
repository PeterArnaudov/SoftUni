namespace AnimalCentre
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            AnimalCentre ac = new AnimalCentre();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                try
                {
                    if (command[0] == "End")
                    {
                        Console.WriteLine(ac.GetAdoptedAnimals());
                        break;
                    }
                    else if (command[0] == "RegisterAnimal")
                    {
                        Console.WriteLine(ac.RegisterAnimal(command[1], command[2],
                            int.Parse(command[3]), int.Parse(command[4]), int.Parse(command[5])));
                    }
                    else if (command[0] == "Chip")
                    {
                        Console.WriteLine(ac.Chip(command[1], int.Parse(command[2])));
                    }
                    else if (command[0] == "Vaccinate")
                    {
                        Console.WriteLine(ac.Vaccinate(command[1], int.Parse(command[2])));
                    }
                    else if (command[0] == "Fitness")
                    {
                        Console.WriteLine(ac.Fitness(command[1], int.Parse(command[2])));
                    }
                    else if (command[0] == "Play")
                    {
                        Console.WriteLine(ac.Play(command[1], int.Parse(command[2])));
                    }
                    else if (command[0] == "DentalCare")
                    {
                        Console.WriteLine(ac.DentalCare(command[1], int.Parse(command[2])));
                    }
                    else if (command[0] == "NailTrim")
                    {
                        Console.WriteLine(ac.NailTrim(command[1], int.Parse(command[2])));
                    }
                    else if (command[0] == "Adopt")
                    {
                        Console.WriteLine(ac.Adopt(command[1], command[2]));
                    }
                    else if (command[0] == "History")
                    {
                        Console.WriteLine(ac.History(command[1]));
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine($"InvalidOperationException: {ioe.Message}");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine($"ArgumentException: {ae.Message}");
                }
            }
        }
    }
}
