namespace SortEvenNumbers
{
    using System;
    using System.Linq;

    public class SortEvenNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", ", numbers.Where(x => x % 2 == 0).OrderBy(x => x)));
        }
    }
}
