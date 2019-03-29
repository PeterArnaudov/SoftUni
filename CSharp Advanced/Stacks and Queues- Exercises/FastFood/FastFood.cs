namespace FastFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FastFood
    {
        public static void Main()
        {
            int food = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(array);

            Console.WriteLine(orders.Max());

            for (int i = 0; i < array.Length; i++)
            {
                if (food - orders.Peek() >= 0)
                {
                    food -= orders.Dequeue();
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
