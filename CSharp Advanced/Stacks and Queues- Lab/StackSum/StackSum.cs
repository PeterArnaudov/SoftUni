namespace StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StackSum
    {
        public static void Main()
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "end")
                {
                    break;
                }
                else if (input.Contains("add"))
                {
                    string[] tokens = input.Split();

                    numbers.Push(int.Parse(tokens[1]));
                    numbers.Push(int.Parse(tokens[2]));
                }
                else if (input.Contains("remove"))
                {
                    string[] tokens = input.Split();

                    if (int.Parse(tokens[1]) <= numbers.Count)
                    {
                        for (int i = 0; i < int.Parse(tokens[1]); i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
