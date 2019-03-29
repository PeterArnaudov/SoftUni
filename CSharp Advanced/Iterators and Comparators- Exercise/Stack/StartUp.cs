namespace Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Stack<string> stack = new Stack<string>();

            while (true)
            {
                string[] commandTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandTokens[0] == "END")
                {
                    break;
                }
                else if (commandTokens[0] == "Push")
                {
                    stack.Push(commandTokens.Skip(1)
                        .Select(t => t.Split(',').First())
                        .ToArray());
                }
                else if (commandTokens[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
