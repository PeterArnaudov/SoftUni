namespace Target_Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            //Input and setup
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int columns = sizes[1];

            char[,] matrix = new char[rows, columns];

            Queue<char> snakeQueue = new Queue<char>(Console.ReadLine());

            //Fill the matrix
            for (int row = rows - 1; row >= 0; row--)
            {
                for (int column = columns - 1; column >= 0; column--)
                {
                    char removed = snakeQueue.Peek();
                    matrix[row, column] = snakeQueue.Dequeue();
                    snakeQueue.Enqueue(removed);
                }

                row--;

                if (row == -1)
                {
                    break;
                }

                for (int column = 0; column < columns; column++)
                {
                    char removed = snakeQueue.Peek();
                    matrix[row, column] = snakeQueue.Dequeue();
                    snakeQueue.Enqueue(removed);
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
                        matrix[row, col] = ' ';
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
                        if (matrix[r, col] == ' ')
                        {
                            matrix[r, col] = matrix[r - 1, col];
                            matrix[r - 1, col] = ' ';
                        }
                    }
                }
            }

            //Print output
            for (int i = 0; i < rows; i++)
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
