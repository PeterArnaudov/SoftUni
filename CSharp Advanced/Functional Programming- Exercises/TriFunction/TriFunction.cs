namespace TriFunction
{
    using System;
    using System.Linq;

    public class TriFunction
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> validator = (name, value) => name.ToCharArray().Select(x => (int)x).Sum() >= number;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (collection, value, func) => collection
                                                                    .FirstOrDefault(name => func(name, value));

            Console.WriteLine(firstValidName(names, number, validator));
        }
    }
}
