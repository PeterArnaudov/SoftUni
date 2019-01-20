namespace MatrixShuffling
{
    using System;
    using System.Linq;

    public class MatrixShuffling
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int columns = sizes[1];

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] inputArray = input.Split();

                if (inputArray.Length != 5 || inputArray[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                bool validIndexes = (int.Parse(inputArray[1]) >= 0 && int.Parse(inputArray[1]) < rows)
                                    && (int.Parse(inputArray[2]) >= 0 && int.Parse(inputArray[2]) < columns)
                                    && (int.Parse(inputArray[3]) >= 0 && int.Parse(inputArray[3]) < rows)
                                    && (int.Parse(inputArray[4]) >= 0 && int.Parse(inputArray[4]) < columns);

                if (!validIndexes)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string original = matrix[int.Parse(inputArray[1]), int.Parse(inputArray[2])];
                matrix[int.Parse(inputArray[1]), int.Parse(inputArray[2])] = matrix[int.Parse(inputArray[3]), int.Parse(inputArray[4])];
                matrix[int.Parse(inputArray[3]), int.Parse(inputArray[4])] = original;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
