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

            int[][] grouped = new int[3][];
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Math.Abs(input[i]) % 3 == 0)
                {
                    numbers.Add(input[i]);
                }
            }
            
            grouped[0] = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                grouped[0][i] = numbers[i];
            }

            numbers.Clear();

            for (int i = 0; i < input.Length; i++)
            {
                if (Math.Abs(input[i]) % 3 == 1)
                {
                    numbers.Add(input[i]);
                }
            }

            grouped[1] = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                grouped[1][i] = numbers[i];
            }

            numbers.Clear();

            for (int i = 0; i < input.Length; i++)
            {
                if (Math.Abs(input[i]) % 3 == 2)
                {
                    numbers.Add(input[i]);
                }
            }

            grouped[2] = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                grouped[2][i] = numbers[i];
            }

            for (int i = 0; i < grouped.Length; i++)
            {
                for (int j = 0; j < grouped[i].Length; j++)
                {
                    Console.Write($"{grouped[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
