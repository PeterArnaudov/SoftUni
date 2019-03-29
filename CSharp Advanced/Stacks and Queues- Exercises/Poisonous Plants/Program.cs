namespace Poisonous_Plants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numberOfPlants = int.Parse(Console.ReadLine());
            List<int> plants = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            bool died = true;
            int day = 0;

            while (died)
            {
                Stack<int> toRemove = new Stack<int>();

                for (int i = 1; i < plants.Count; i++)
                {
                    if (plants[i] > plants[i - 1])
                    {
                        toRemove.Push(i);
                    }
                }

                if (toRemove.Count == 0)
                {
                    died = false;
                    continue;
                }

                while (toRemove.Count != 0)
                {
                    plants.RemoveAt(toRemove.Pop());
                }

                day++;
            }

            Console.WriteLine(day);
        }
    }
}
