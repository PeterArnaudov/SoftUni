namespace Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaximumElement
    {
        public static void Main()
        {
            int commandsCount = int.Parse(Console.ReadLine());

            Stack<int> numbersStack = new Stack<int>();

            for (int i = 0; i < commandsCount; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    numbersStack.Push(command[1]);
                }
                else if (command[0] == 2 && numbersStack.Count > 0)
                {
                    numbersStack.Pop();
                }
                else if (command[0] == 3 && numbersStack.Count > 0)
                {
                    Console.WriteLine(numbersStack.Max());
                }
            }
        }
    }
}
