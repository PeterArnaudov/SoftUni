namespace KeyRevolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyRevolver
    {
        public static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int money = int.Parse(Console.ReadLine());

            int currentBarrel = gunBarrel;

            while (bullets.Count != 0 && locks.Count != 0)
            {
                currentBarrel--;
                int currentBullet = bullets.Pop();
                money -= bulletPrice;

                if (currentBullet <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currentBarrel == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    currentBarrel = gunBarrel;
                }
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${money}");
            }
            else if (bullets.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
