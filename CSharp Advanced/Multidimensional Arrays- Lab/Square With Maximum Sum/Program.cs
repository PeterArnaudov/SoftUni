namespace Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = elements[column];
                }
            }

            int bestSquareSum = 0;
            int[] bestNumbers = new int[4];

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 1; column++)
                {
                    int newSquareSum = matrix[row, column] + matrix[row, column + 1] + matrix[row + 1, column] + matrix[row + 1, column + 1];

                    if (newSquareSum > bestSquareSum)
                    {
                        bestSquareSum = newSquareSum;

                        bestNumbers[0] = matrix[row, column];
                        bestNumbers[1] = matrix[row, column + 1];
                        bestNumbers[2] = matrix[row + 1, column];
                        bestNumbers[3] = matrix[row + 1, column + 1];
                    }
                }
            }

            Console.WriteLine($"{bestNumbers[0]} {bestNumbers[1]}");
            Console.WriteLine($"{bestNumbers[2]} {bestNumbers[3]}");
            Console.WriteLine(bestSquareSum);
        }
    }
}
