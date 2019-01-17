namespace Pascal_Triangle
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                for (int element = 0; element < row + 1; element++)
                {
                    if (element == pascalTriangle[row].Length - 1 || element == 0)
                    {
                        pascalTriangle[row][element] = 1;
                    }
                    else
                    {
                        pascalTriangle[row][element] = pascalTriangle[row - 1][element - 1] + pascalTriangle[row - 1][element];
                    }
                }
            }

            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                for (int element = 0; element < pascalTriangle[row].Length; element++)
                {
                    Console.Write($"{pascalTriangle[row][element]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
