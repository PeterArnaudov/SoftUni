namespace Supermarket
{
    using System;
    using System.Collections.Generic;

    public class Supermarket
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Queue<string> names = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (names.Count != 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else
                {
                    names.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
