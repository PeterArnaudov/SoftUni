namespace FashionBoutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FashionBoutique
    {
        public static void Main()
        {
            int[] clothesArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            int racks = 1;
            Stack<int> clothes = new Stack<int>(clothesArray);

            int currentRack = capacity;
            
            while (clothes.Count != 0)
            {
                if (currentRack - clothes.Peek() >= 0)
                {
                    currentRack -= clothes.Pop();
                }
                else
                {
                    racks++;
                    currentRack = capacity - clothes.Pop();
                }
            }

            Console.WriteLine(racks);
        }
    }
}
