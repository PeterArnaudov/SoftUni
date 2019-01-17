namespace Bombs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Bombs
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            Queue<int> bombs = new Queue<int>(Console.ReadLine().Split(' ', ',').Select(int.Parse));

            while (bombs.Count != 0)
            {
                int bombRow = bombs.Dequeue();
                int bombColumn = bombs.Dequeue();

                DetonateBomb(bombRow, bombColumn, matrix);
            }

            int aliveCells = 0;
            int sum = 0;

            foreach (var row in matrix)
            {
                foreach (var cell in row)
                {
                    if (cell > 0)
                    {
                        aliveCells++;
                        sum += cell;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        public static bool IsCellInMatrix(int row, int column, int[][] matrix)
        {
            if (row >= 0 && row < matrix.Length && column >= 0 && column < matrix[row].Length)
            {
                return true;
            }

            return false;
        }

        public static bool IsCellDead(int row, int column, int[][] matrix)
        {
            if (IsCellInMatrix(row, column, matrix))
            {
                if (matrix[row][column] <= 0)
                {
                    return true;
                }
            }            

            return false;
        }

        public static void DetonateBomb(int bombRow, int bombColumn, int[][] matrix)
        {
            if (matrix[bombRow][bombColumn] > 0)
            {
                int bombPower = matrix[bombRow][bombColumn];
                matrix[bombRow][bombColumn] = 0;

                if (IsCellInMatrix(bombRow - 1, bombColumn - 1, matrix) && !IsCellDead(bombRow - 1, bombColumn - 1, matrix))
                {
                    matrix[bombRow - 1][bombColumn - 1] -= bombPower;
                }
                if (IsCellInMatrix(bombRow - 1, bombColumn, matrix) && !IsCellDead(bombRow - 1, bombColumn, matrix))
                {
                    matrix[bombRow - 1][bombColumn] -= bombPower;
                }
                if (IsCellInMatrix(bombRow - 1, bombColumn + 1, matrix) && !IsCellDead(bombRow - 1, bombColumn + 1, matrix))
                {
                    matrix[bombRow - 1][bombColumn + 1] -= bombPower;
                }
                if (IsCellInMatrix(bombRow, bombColumn - 1, matrix) && !IsCellDead(bombRow, bombColumn - 1, matrix))
                {
                    matrix[bombRow][bombColumn - 1] -= bombPower;
                }
                if (IsCellInMatrix(bombRow, bombColumn + 1, matrix) && !IsCellDead(bombRow, bombColumn + 1, matrix))
                {
                    matrix[bombRow][bombColumn + 1] -= bombPower;
                }
                if (IsCellInMatrix(bombRow + 1, bombColumn - 1, matrix) && !IsCellDead(bombRow + 1, bombColumn - 1, matrix))
                {
                    matrix[bombRow + 1][bombColumn - 1] -= bombPower;
                }
                if (IsCellInMatrix(bombRow + 1, bombColumn, matrix) && !IsCellDead(bombRow + 1, bombColumn, matrix))
                {
                    matrix[bombRow + 1][bombColumn] -= bombPower;
                }
                if (IsCellInMatrix(bombRow + 1, bombColumn + 1, matrix) && !IsCellDead(bombRow + 1, bombColumn + 1, matrix))
                {
                    matrix[bombRow + 1][bombColumn + 1] -= bombPower;
                }
            }
        }
    }
}
