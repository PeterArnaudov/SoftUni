namespace CubicArtillery
{
    using System;
    using System.Collections.Generic;

    public class CubicArtillery
    {
        public static void Main()
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();
            int currentBunkerCapacity = maxCapacity;
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Bunker Revision")
                {
                    return;
                }

                string[] info = input.Split();

                foreach (var item in info)
                {
                    if (char.IsLetter(item[0]))
                    {
                        bunkers.Enqueue(item);
                    }
                    else
                    {
                        int weaponCapacity = int.Parse(item);

                        bool weaponContained = false;
                        while (bunkers.Count > 1)
                        {
                            if (currentBunkerCapacity >= weaponCapacity)
                            {
                                weapons.Enqueue(weaponCapacity);
                                currentBunkerCapacity -= weaponCapacity;
                                weaponContained = true;
                                break;
                            }

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{bunkers.Peek()} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{bunkers.Peek()} -> {string.Join(", ", weapons)}");
                            }

                            bunkers.Dequeue();
                            weapons.Clear();
                            currentBunkerCapacity = maxCapacity;
                        }

                        if (!weaponContained && bunkers.Count == 1)
                        {
                            if (maxCapacity >= weaponCapacity)
                            {
                                if (currentBunkerCapacity < weaponCapacity)
                                {
                                    while (currentBunkerCapacity < weaponCapacity)
                                    {
                                        int removedWeapon = weapons.Dequeue();
                                        currentBunkerCapacity += removedWeapon;
                                    }
                                }

                                weapons.Enqueue(weaponCapacity);
                                currentBunkerCapacity -= weaponCapacity;
                            }
                        }
                    }
                }
            }
        }
    }
}
