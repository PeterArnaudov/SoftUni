namespace SnakeMoves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SnakeMoves
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            Queue<char> snakeQueue = new Queue<char>(snake);
            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                for (int j = 0; j < sizes[1]; j++)
                {
                    if (snakeQueue.Count == 0)
                    {
                        snakeQueue = new Queue<char>(snake);
                    }

                    matrix[i, j] = snakeQueue.Dequeue();
                }
            }

            for (int i = 0; i < sizes[0]; i++)
            {
                for (int j = 0; j < sizes[1]; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
