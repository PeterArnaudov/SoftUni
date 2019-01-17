namespace CustomMinFunction
{
    using System;
    using System.Linq;

    public class CustomMinFunction
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minFunc = x =>
            {
                int min = int.MaxValue;

                foreach (var num in x)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }

                return min;
            };

            Console.WriteLine(minFunc(numbers));
        }
    }
}
