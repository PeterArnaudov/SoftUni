namespace Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicQueueOperations
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numbersToDequeue = input[1];
            int numberToFind = input[2];

            Queue<int> numbersStack = new Queue<int>(numbers);

            for (int i = 0; i < numbersToDequeue; i++)
            {
                if (numbersStack.Count == 0)
                {
                    break;
                }

                numbersStack.Dequeue();
            }

            if (numbersStack.Contains(numberToFind))
            {
                Console.WriteLine("true");
            }
            else if (numbersStack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numbersStack.Min());
            }
        }
    }
}
