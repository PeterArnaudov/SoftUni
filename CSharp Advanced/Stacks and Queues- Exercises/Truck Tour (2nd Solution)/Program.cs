namespace Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static int pumpsNumber = int.Parse(Console.ReadLine());
        static Queue<int[]> pumps = new Queue<int[]>();

        public static void Main()
        {
            // this is the same solution, but here I use variables in the class (static int, queue) to make sure I can use them in both the Main and IsSolution methods

            for (int i = 0; i < pumpsNumber; i++)
            {
                pumps.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            for (int i = 0; i < pumpsNumber; i++)
            {
                if (IsSolution())
                {
                    Console.WriteLine(i);
                    break;
                }

                pumps.Enqueue(pumps.Dequeue());
            }
        }

        static bool IsSolution()
        {
            int petrol = 0;
            bool foundAnswer = true;

            for (int i = 0; i < pumpsNumber; i++)
            {
                int[] current = pumps.Dequeue();

                petrol += current[0];
                petrol -= current[1];

                if (petrol < 0)
                {
                    foundAnswer = false;
                }

                pumps.Enqueue(current);
            }

            if (foundAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}