namespace Sequence_With_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            //solution with two queues
            long number = long.Parse(Console.ReadLine());

            Queue<long> queue = new Queue<long>();
            Queue<long> sequenceQueue = new Queue<long>();

            queue.Enqueue(number);

            while (sequenceQueue.Count != 50)
            {
                long current = queue.Dequeue();
                sequenceQueue.Enqueue(current);

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            while (sequenceQueue.Count != 0)
            {
                Console.Write($"{sequenceQueue.Dequeue()} ");
            }

            //solution with one queue
            //long number = long.Parse(Console.ReadLine());

            //Queue<long> sequenceQueue = new Queue<long>();
            //sequenceQueue.Enqueue(number);
            //int index = 0;

            //while (true)
            //{
            //    index++;

            //    long current = sequenceQueue.Dequeue();
            //    Console.Write($"{current} ");

            //    if (index == 50)
            //    {
            //        return;
            //    }

            //    sequenceQueue.Enqueue(current + 1);
            //    sequenceQueue.Enqueue(2 * current + 1);
            //    sequenceQueue.Enqueue(current + 2);
            //}

        }
    }
}
