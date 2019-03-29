namespace Reverse_Strings
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> inputStack = new Stack<char>();

            foreach (var character in input)
            {
                inputStack.Push(character);
            }

            while (inputStack.Count != 0)
            {
                Console.Write(inputStack.Pop());
            }

            Console.WriteLine();
        }
    }
}
