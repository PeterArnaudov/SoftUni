namespace Squares_in_Matrix
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

            char[][] matrix = new char[rows][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            int count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int column = 0; column < columns - 1; column++)
                {
                    if (matrix[row][column] == matrix[row][column + 1] && matrix[row][column] == matrix[row + 1][column] && matrix[row][column] == matrix[row + 1][column + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
