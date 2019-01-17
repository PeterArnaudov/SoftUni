namespace Sequence_With_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            List<long> sequence = new List<long>();
            Queue<long> sequenceQueue = new Queue<long>();
            sequenceQueue.Enqueue(number);

            long current = number;

            for (int i = 0, j = 0; i < 49; i += 3, j++)
            {
                sequenceQueue.Enqueue(current + 1);
                sequenceQueue.Enqueue(2 * current + 1);
                sequenceQueue.Enqueue(current + 2);

                sequence.Add(current + 1);
                sequence.Add(2 * current + 1);
                sequence.Add(current + 2);

                current = sequence[j];
            }

            while (sequenceQueue.Count != 2)
            {
                Console.Write($"{sequenceQueue.Dequeue()} ");
            }
        }
    }
}
