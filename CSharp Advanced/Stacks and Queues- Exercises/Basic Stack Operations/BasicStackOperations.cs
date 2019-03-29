namespace Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicStackOperations
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numbersCount = input[0];
            int numbersToPop = input[1];
            int numberToFind = input[2];

            Stack<int> numbersStack = new Stack<int>();

            for (int i = 0; i < numbersCount; i++)
            {
                numbersStack.Push(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                numbersStack.Pop();
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
