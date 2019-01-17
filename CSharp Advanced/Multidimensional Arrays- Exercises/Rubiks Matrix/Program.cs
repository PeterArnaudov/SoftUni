namespace Rubiks_Matrix
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

            int[][] matrix = new int[rows][];
            int number = 1;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    matrix[i][j] = number;
                    number++;
                }
            }

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string command = Console.ReadLine();

                if (command.Contains("up"))
                {
                    int[] commandArray = command.Split(" up ").Select(int.Parse).ToArray();

                    int column = commandArray[0];
                    int positions = commandArray[1];

                    for (int j = 0; j < positions % columns; j++)
                    {
                        int firstElement = matrix[0][column];

                        for (int k = 0; k < columns - 1; k++)
                        {
                            matrix[k][column] = matrix[k + 1][column];
                        }

                        matrix[rows - 1][column] = firstElement;
                    }
                }
                else if (command.Contains("down"))
                {
                    int[] commandArray = command.Split(" down ").Select(int.Parse).ToArray();

                    int column = commandArray[0];
                    int positions = commandArray[1];

                    for (int j = 0; j < positions % columns; j++)
                    {
                        int lastElement = matrix[rows - 1][column];

                        for (int k = columns - 1; k > 0; k--)
                        {
                            matrix[k][column] = matrix[k - 1][column];
                        }

                        matrix[0][column] = lastElement;
                    }
                }
                else if (command.Contains("left"))
                {
                    int[] commandArray = command.Split(" left ").Select(int.Parse).ToArray();

                    int row = commandArray[0];
                    int positions = commandArray[1];

                    for (int j = 0; j < positions % columns; j++)
                    {
                        int firstElement = matrix[row][0];

                        for (int k = 0; k < columns - 1; k++)
                        {
                            matrix[row][k] = matrix[row][k + 1];
                        }

                        matrix[row][columns - 1] = firstElement;
                    }
                }
                else if (command.Contains("right"))
                {
                    int[] commandArray = command.Split(" right ").Select(int.Parse).ToArray();

                    int row = commandArray[0];
                    int positions = commandArray[1];

                    for (int j = 0; j < positions % columns; j++)
                    {
                        int lastElement = matrix[row][columns - 1];

                        for (int k = columns - 1; k > 0; k--)
                        {
                            matrix[row][k] = matrix[row][k - 1];
                        }

                        matrix[row][0] = lastElement;
                    }
                }
            }

            for (int i = 0, counter = 1; i < rows; i++)
            {
                for (int j = 0; j < columns; j++, counter++)
                {
                    if (matrix[i][j] == counter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < rows; r++)
                        {
                            bool found = false;

                            for (int c = 0; c < columns; c++)
                            {
                                if (matrix[r][c] == counter)
                                {
                                    found = true;
                                    int old = matrix[i][j];
                                    matrix[i][j] = matrix[r][c];
                                    matrix[r][c] = old;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({r}, {c})");
                                    break;
                                }
                            }

                            if (found)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}