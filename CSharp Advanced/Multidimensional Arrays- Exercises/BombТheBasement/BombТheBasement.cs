namespace BombТheBasement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombТheBasement
    {
        public static void Main()
        {
            //Input and setup
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int columns = sizes[1];

            int[,] matrix = new int[rows, columns];

            //Fill the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            //Pythagorean Theorem ~ Fire the shot
            int[] shot = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int shotRow = shot[0];
            int shotColumn = shot[1];
            int shotRadius = shot[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - shotRow, 2) + Math.Pow(col - shotColumn, 2));
                    if (distance <= shotRadius)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            //Characters fall ~ Gravity
            for (int col = 0; col < columns; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int r = rows - 1; r > 0; r--)
                    {
                        if (matrix[r, col] == 0)
                        {
                            matrix[r, col] = matrix[r - 1, col];
                            matrix[r - 1, col] = 0;
                        }
                    }
                }
            }

            //Print output
            for (int i = rows - 1; i >= 0; i--)
            {
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{matrix[i, j]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
