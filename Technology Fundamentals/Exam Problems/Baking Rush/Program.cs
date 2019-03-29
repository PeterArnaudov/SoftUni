using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baking_Rush
{
    public class Program
    {
        public static void Main()
        {
            int energy = 100;
            int coins = 100;
            List<string> events = Console.ReadLine().Split('|', '-').ToList();

            while (true)
            {
                string task = events[0];
                int quantity = int.Parse(events[1]);

                if (task == "rest")
                {
                    int pastEnergy = energy;
                    energy += quantity;

                    if (energy > 100)
                    {
                        energy = 100;
                    }

                    int gained = energy - pastEnergy;

                    if (pastEnergy == 100)
                    {
                        gained = 0;
                    }

                    Console.WriteLine($"You gained {gained} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (task == "order")
                {
                    if (energy >= 30)
                    {
                        energy -= 30;
                        coins += quantity;
                        Console.WriteLine($"You earned {quantity} coins.");
                    }
                    else
                    {
                        energy += 50;

                        if (energy > 100)
                        {
                            energy = 100;
                        }

                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    if (coins > quantity)
                    {
                        coins -= quantity;
                        Console.WriteLine($"You bought {task}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {task}.");
                        return;
                    }
                }

                events.RemoveRange(0, 2);

                if (events.Count == 0)
                {
                    break;
                }
            }

            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}