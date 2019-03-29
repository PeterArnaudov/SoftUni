namespace Maximal_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int columns = sizes[1];

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int bestSum = int.MinValue;
            int[][] outputMatrix = new int[3][];

            for (int row = 0; row < rows - 2; row++)
            {
                for (int column = 0; column < columns - 2; column++)
                {
                    int currentSum = matrix[row][column] + matrix[row][column + 1] + matrix[row][column + 2] + matrix[row + 1][column] + matrix[row + 1][column + 1] + matrix[row + 1][column + 2] + matrix[row + 2][column] + matrix[row + 2][column + 1] + matrix[row + 2][column + 2];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;

                        for (int i = 0; i < 3; i++)
                        {
                            outputMatrix[i] = new int[3];

                            for (int j = 0; j < 3; j++)
                            {
                                outputMatrix[i][j] = matrix[row + i][column + j];
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {bestSum}");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Join(" ", outputMatrix[i]));
            }
        }
    }
}
