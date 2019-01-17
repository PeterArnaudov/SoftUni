namespace Reverse_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(input);

            while (numbers.Count != 0)
            {
                Console.Write($"{numbers.Pop()} ");
            }
        }
    }
}
