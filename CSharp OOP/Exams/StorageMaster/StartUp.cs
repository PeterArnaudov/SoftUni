namespace StorageMaster
{
    using System;
    using System.Linq;
    using Core;

    public class StartUp
    {
        public static void Main()
        {
            StorageMaster sm = new StorageMaster();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                try
                {
                    if (command[0] == "END")
                    {
                        Console.WriteLine(sm.GetSummary());
                        break;
                    }
                    else if (command[0] == "AddProduct")
                    {
                        Console.WriteLine(sm.AddProduct(command[1], double.Parse(command[2])));
                    }
                    else if (command[0] == "RegisterStorage")
                    {
                        Console.WriteLine(sm.RegisterStorage(command[1], command[2]));
                    }
                    else if (command[0] == "SelectVehicle")
                    {
                        Console.WriteLine(sm.SelectVehicle(command[1], int.Parse(command[2])));
                    }
                    else if (command[0] == "LoadVehicle")
                    {
                        Console.WriteLine(sm.LoadVehicle(command.Skip(1)));
                    }
                    else if (command[0] == "SendVehicleTo")
                    {
                        Console.WriteLine(sm.SendVehicleTo(command[1], int.Parse(command[2]), command[3]));
                    }
                    else if (command[0] == "UnloadVehicle")
                    {
                        Console.WriteLine(sm.UnloadVehicle(command[1], int.Parse(command[2])));
                    }
                    else if (command[0] == "GetStorageStatus")
                    {
                        Console.WriteLine(sm.GetStorageStatus(command[1]));
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine($"Error: {ioe.Message}");
                }
            }
        }
    }
}
