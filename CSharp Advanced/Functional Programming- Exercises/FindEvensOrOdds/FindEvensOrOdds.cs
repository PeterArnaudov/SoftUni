namespace FindEvensOrOdds
{
    using System;
    using System.Linq;

    public class FindEvensOrOdds
    {
        public static void Main()
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string type = Console.ReadLine();

            Predicate<int> isEven = x => x % 2 == 0;

            int[] filtered = Enumerable.Range(range[0], range[1] - range[0] + 1).Where((x => type == "even" ? isEven(x) : !isEven(x))).ToArray();

            Console.WriteLine(string.Join(" ", filtered));
        }
    }
}
