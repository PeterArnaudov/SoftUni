namespace Group_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            List<int> remainderZero = input.Where(x => Math.Abs(x) % 3 == 0).ToList();
            List<int> remainderOne = input.Where(x => Math.Abs(x) % 3 == 1).ToList();
            List<int> remainderTwo = input.Where(x => Math.Abs(x) % 3 == 2).ToList();

            Console.WriteLine(string.Join(" ", remainderZero));
            Console.WriteLine(string.Join(" ", remainderOne));
            Console.WriteLine(string.Join(" ", remainderTwo));
        }
    }
}
