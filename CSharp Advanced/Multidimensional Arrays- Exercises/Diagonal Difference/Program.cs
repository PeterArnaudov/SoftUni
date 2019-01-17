namespace Diagonal_Difference
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0, k = size - 1; i < size; i++, k--)
            {
                primaryDiagonalSum += matrix[i, i];
                secondaryDiagonalSum += matrix[i, k];
            }

            int difference = primaryDiagonalSum - secondaryDiagonalSum;

            Console.WriteLine(Math.Abs(difference));
        }
    }
}
