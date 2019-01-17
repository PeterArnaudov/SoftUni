namespace Sum_Matrix_Elements
{
    using System;
    using System.Linq;
    
    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++) //for each dimension (row) read its elements
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int column = 0; column < matrix.GetLength(1); column++) //fill the dimension (row's columns) with the read elements
                {
                    matrix[row, column] = elements[column];
                }
            }

            int sum = 0;

            foreach (var element in matrix) //goes through every single element in the whole array- each element in each dimension
            {
                sum += element;
            }

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        sum += matrix[row, col];
            //    }
            //}

            Console.WriteLine(matrix.GetLength(0)); //gets the number of rows (zero dimension)
            Console.WriteLine(matrix.GetLength(1)); //gets the number of elements in a column (first dimension)
            Console.WriteLine(sum);
        }
    }
}
