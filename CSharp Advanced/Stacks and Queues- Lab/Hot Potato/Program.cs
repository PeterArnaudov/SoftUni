namespace Hot_Potato
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>(input);

            while (children.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    children.Enqueue(children.Dequeue());
                }

                Console.WriteLine($"Removed {children.Dequeue()}");
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
