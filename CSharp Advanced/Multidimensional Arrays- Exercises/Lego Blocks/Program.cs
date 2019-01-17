namespace Lego_Blocks
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] firstBlock = new int[rows][];
            int[][] secondBlock = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                firstBlock[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int i = 0; i < rows; i++)
            {
                secondBlock[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int i = 0; i < rows; i++)
            {
                Array.Reverse(secondBlock[i]);
            }

            int[][] combined = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                combined[i] = new int[firstBlock[i].Length + secondBlock[i].Length];

                for (int j = 0; j < firstBlock[i].Length; j++)
                {
                    combined[i][j] = firstBlock[i][j];
                }

                for (int j = firstBlock[i].Length, k = 0; k < secondBlock[i].Length; j++, k++)
                {
                    combined[i][j] = secondBlock[i][k];
                }
            }

            bool fit = false;

            for (int i = 0; i < combined.Length; i++)
            {
                if (combined[i].Length == combined[0].Length)
                {
                    fit = true;
                }
                else
                {
                    fit = false;
                    break;
                }
            }

            if (fit)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", combined[i])}]");
                }
            }
            else
            {
                int numberOfCells = 0;

                foreach (var array in combined)
                {
                    foreach (var element in array)
                    {
                        numberOfCells++;
                    }
                }

                Console.WriteLine($"The total number of cells is: {numberOfCells}");
            }
        }
    }
}
