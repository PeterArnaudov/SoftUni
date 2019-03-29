namespace Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int pumpsNumber = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < pumpsNumber; i++)
            {
                pumps.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray()); //read the input
            }

            for (int j = 0; j < pumpsNumber; j++)
            {
                int petrol = 0;
                bool answerFound = true;

                for (int i = 0; i < pumpsNumber; i++)
                {
                    int[] current = pumps.Dequeue(); //take the information about the current pump

                    petrol += current[0]; //petrol filled
                    petrol -= current[1]; //petrol used

                    if (petrol < 0)
                    {
                        answerFound = false; //check if it completes the route, it is doesn't - return false, but don't break the cycle as you need to make a complete cycle so that you can start with the next cycle (and also the next beginning index/pump)
                    }

                    pumps.Enqueue(current); //add the current pump to the end of the queue
                }

                if (answerFound) //if you found the smallest possible index for a full cycle - print the index of the pump and interrupt the program
                {
                    Console.WriteLine(j);
                    return;
                }

                pumps.Enqueue(pumps.Dequeue()); //move the first element to the end of the queue, so that you can start the new cycle with different pump(index)
            }
        }
    }
}
