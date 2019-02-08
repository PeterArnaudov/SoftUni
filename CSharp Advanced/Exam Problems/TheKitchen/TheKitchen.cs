namespace TheKitchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TheKitchen
    {
        public static void Main()
        {
            Stack<int> knives = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> forks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> sets = new List<int>();

            int increment = 0;
            while (knives.Count != 0 && forks.Count != 0)
            {
                int currentKnife = knives.Peek() + increment;
                int currentFork = forks.Peek();

                if (currentKnife > currentFork)
                {
                    sets.Add(currentKnife + currentFork);
                    knives.Pop();
                    forks.Dequeue();
                    increment = 0;
                }
                else if (currentFork > currentKnife)
                {
                    knives.Pop();
                    increment = 0;
                }
                else if (currentKnife == currentFork)
                {
                    forks.Dequeue();
                    increment++;
                }
            }

            Console.WriteLine($"The biggest set is: {sets.Max()}");
            Console.WriteLine(string.Join(' ', sets));
        }
    }
}
