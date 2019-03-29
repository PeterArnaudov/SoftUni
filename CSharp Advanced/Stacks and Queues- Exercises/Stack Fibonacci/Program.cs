namespace Stack_Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            long index = long.Parse(Console.ReadLine());

            Stack<long> fibonacciStack = new Stack<long>();
            fibonacciStack.Push(0);
            fibonacciStack.Push(1);

            for (int i = 0; i < index - 1; i++)
            {
                long old = fibonacciStack.Pop();
                long older = fibonacciStack.Peek();
                fibonacciStack.Push(old);
                fibonacciStack.Push(old + older);
            }

            Console.WriteLine(fibonacciStack.Pop());
        }
    }
}
