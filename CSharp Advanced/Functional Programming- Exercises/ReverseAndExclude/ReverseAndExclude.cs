namespace ReverseAndExclude
{
    using System;
    using System.Linq;

    public class ReverseAndExclude
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divideNumber = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % divideNumber != 0;

            Console.WriteLine(string.Join(" ", numbers.Reverse().Where(x => filter(x))));
        }
    }
}
