using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeonest_Dark
{
    public class Program
    {
        public static void Main()
        {
            string[] rooms = Console.ReadLine().Split('|');
            int health = 100;
            int coins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currentRoom = rooms[i].Split();
                string monster = currentRoom[0];
                int number = int.Parse(currentRoom[1]);

                if (monster == "potion")
                {
                    int pastHealth = health;
                    health += number;

                    if (health > 100)
                    {
                        health = 100;
                    }

                    int gained = health - pastHealth;

                    if (pastHealth == 100)
                    {
                        gained = 0;
                    }

                    Console.WriteLine($"You healed for {gained} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (monster == "chest")
                {
                    coins += number;

                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    health -= number;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
