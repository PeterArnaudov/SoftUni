namespace CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSameValuesInArray
    {
        public static void Main()
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> occurences = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!occurences.ContainsKey(input[i]))
                {
                    occurences.Add(input[i], 0);
                }

                occurences[input[i]]++;
            }

            foreach (var kvp in occurences)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
