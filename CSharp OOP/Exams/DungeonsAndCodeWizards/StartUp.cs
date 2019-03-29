namespace DungeonsAndCodeWizards
{
    using DungeonsAndCodeWizards.Core;
    using System;
    using System.Linq;

    public class StartUp
	{
		// DO NOT rename this file's namespace or class name.
		// However, you ARE allowed to use your own namespaces (or no namespaces at all if you prefer) in other classes.
		public static void Main()
		{
            DungeonMaster dm = new DungeonMaster();

            string input;
            while (!dm.IsGameOver() && !string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                string[] command = input.Split();

                try
                {
                    if (command[0] == "JoinParty")
                    {
                        Console.WriteLine(dm.JoinParty(command.Skip(1).ToArray()));
                    }
                    else if (command[0] == "AddItemToPool")
                    {
                        Console.WriteLine(dm.AddItemToPool(command.Skip(1).ToArray()));
                    }
                    else if (command[0] == "PickUpItem")
                    {
                        Console.WriteLine(dm.PickUpItem(command.Skip(1).ToArray()));
                    }
                    else if (command[0] == "UseItem")
                    {
                        Console.WriteLine(dm.UseItem(command.Skip(1).ToArray()));
                    }
                    else if (command[0] == "UseItemOn")
                    {
                        Console.WriteLine(dm.UseItemOn(command.Skip(1).ToArray()));
                    }
                    else if (command[0] == "GiveCharacterItem")
                    {
                        Console.WriteLine(dm.GiveCharacterItem(command.Skip(1).ToArray()));
                    }
                    else if (command[0] == "GetStats")
                    {
                        Console.WriteLine(dm.GetStats());
                    }
                    else if (command[0] == "Attack")
                    {
                        Console.WriteLine(dm.Attack(command.Skip(1).ToArray()));
                    }
                    else if (command[0] == "Heal")
                    {
                        Console.WriteLine(dm.Heal(command.Skip(1).ToArray()));
                    }
                    else if (command[0] == "EndTurn")
                    {
                        Console.WriteLine(dm.EndTurn(command.Skip(1).ToArray()));
                    }
                    else if (command[0] == "IsGameOver")
                    {
                        dm.IsGameOver();
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine($"Parameter Error: {ae.Message}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine($"Invalid Operation: {ioe.Message}");
                }
            }

            Console.WriteLine("Final stats:");
            Console.WriteLine(dm.GetStats());
        }
	}
}