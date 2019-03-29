namespace SumNumbers
{
    using System;
    using System.Linq;

    public class SumNumbers
    {
        public static void Main()
        {
            Func<string, int> parser = n => int.Parse(n);

            int[] numbers = Console.ReadLine().Split(", ").Select(parser).ToArray();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
