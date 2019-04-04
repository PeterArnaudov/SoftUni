namespace SoftUniRestaurant
{
    using SoftUniRestaurant.Core;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            RestaurantController rc = new RestaurantController();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                try
                {
                    if (command[0] == "END")
                    {
                        Console.WriteLine(rc.GetSummary());
                        break;
                    }
                    else if (command[0] == "AddFood")
                    {
                        Console.WriteLine(rc.AddFood(command[1], command[2], decimal.Parse(command[3])));
                    }
                    else if (command[0] == "AddDrink")
                    {
                        Console.WriteLine(rc.AddDrink(command[1], command[2], int.Parse(command[3]), command[4]));
                    }
                    else if (command[0] == "AddTable")
                    {
                        Console.WriteLine(rc.AddTable(command[1], int.Parse(command[2]), int.Parse(command[3])));
                    }
                    else if (command[0] == "ReserveTable")
                    {
                        Console.WriteLine(rc.ReserveTable(int.Parse(command[1])));
                    }
                    else if (command[0] == "OrderFood")
                    {
                        Console.WriteLine(rc.OrderFood(int.Parse(command[1]), command[2]));
                    }
                    else if (command[0] == "OrderDrink")
                    {
                        Console.WriteLine(rc.OrderDrink(int.Parse(command[1]), command[2], command[3]));
                    }
                    else if (command[0] == "LeaveTable")
                    {
                        Console.WriteLine(rc.LeaveTable(int.Parse(command[1])));
                    }
                    else if (command[0] == "GetFreeTablesInfo")
                    {
                        Console.WriteLine(rc.GetFreeTablesInfo());
                    }
                    else if (command[0] == "GetOccupiedTablesInfo")
                    {
                        Console.WriteLine(rc.GetOccupiedTablesInfo());
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
