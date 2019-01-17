namespace ListOfPredicates
{
    using System;
    using System.Linq;

    public class ListOfPredicates
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (range <= 0)
            {
                return;
            }

            Func<int[], int, bool> filter = (allDividers, number) =>
            {
                bool divisible = true;

                for (int i = 0; i < allDividers.Length; i++)
                {
                    if (number % allDividers[i] != 0)
                    {
                        divisible = false;
                        break;
                    }
                }

                return divisible;
            };

            int[] divisbleNumbers = Enumerable.Range(1, range).Where(x => filter(dividers, x)).ToArray();

            Console.WriteLine(string.Join(" ", divisbleNumbers));
        }
    }
}
