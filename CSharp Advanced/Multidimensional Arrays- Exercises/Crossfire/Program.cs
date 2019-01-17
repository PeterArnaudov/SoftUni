namespace Crossfire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int columns = sizes[1];

            int[][] matrix = new int[rows][];

            for (int row = 0, number = 1; row < rows; row++)
            {
                matrix[row] = new int[columns];
                for (int column = 0; column < columns; column++, number++)
                {
                    matrix[row][column] = number;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Nuke it from orbit")
                {
                    break;
                }

                int[] fire = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int fireRow = fire[0];
                int fireColumn = fire[1];
                int fireRadius = fire[2];

                //up and down
                for (int column = fireColumn - fireRadius; column <= fireColumn + fireRadius; column++)
                {
                    if (AreIndexesValid(fireRow, column, matrix))
                    {
                        matrix[fireRow][column] = 0;
                    }
                }

                //left and right
                for (int row = fireRow - fireRadius; row <= fireRow + fireRadius; row++)
                {
                    if (AreIndexesValid(row, fireColumn, matrix))
                    {
                        matrix[row][fireColumn] = 0;
                    }
                }

                //rearrange
                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row].Any(c => c == 0))
                    {
                        matrix[row] = matrix[row].Where(n => n > 0).ToArray();
                    }

                    if (matrix[row].Length < 1)
                    {
                        matrix = matrix.Take(row).Concat(matrix.Skip(row + 1)).ToArray();
                        row--;
                    }
                }
            }

            //print matrix
            foreach (var row in matrix)
            {
                if (row.Any(n => n > 0))
                {
                    Console.WriteLine(string.Join(" ", row.Where(n => n > 0)));
                }
            }
        }

        //check if indexes are valid
        private static bool AreIndexesValid(int row, int col, int[][] matrix)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }
    }
}
