namespace Matrix_of_Palindromes
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

            string[][] matrix = new string[rows][];

            for (int i = 0, l = 97; i < rows; i++, l++)
            {
                matrix[i] = new string[columns];

                for (int j = 0, k = l; j < matrix[i].Length; j++, k++)
                {
                    matrix[i][j] = $"{(char)l}{(char)k}{(char)l}";
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
