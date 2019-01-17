namespace CupsAndBottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CupsAndBottles
    {
        public static void Main()
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedWater = 0;
            int currentCup = cups.Peek();

            while (cups.Count != 0 && bottles.Count != 0)
            {
                currentCup -= bottles.Pop();

                if (currentCup == 0)
                {
                    cups.Dequeue();

                    if (cups.Any())
                    {
                        currentCup = cups.Peek();
                    }
                }
                else if (currentCup < 0)
                {
                    wastedWater += Math.Abs(currentCup);
                    cups.Dequeue();

                    if (cups.Any())
                    {
                        currentCup = cups.Peek();
                    }
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
