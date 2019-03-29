namespace Jagged_Array_Modification
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[matrixRows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[elements.Length];

                for (int column = 0; column < jagged[row].Length; column++)
                {
                    jagged[row][column] = elements[column];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] commandArray = command.Split();

                string commandType = commandArray[0];
                int row = int.Parse(commandArray[1]);
                int column = int.Parse(commandArray[2]);
                int value = int.Parse(commandArray[3]);

                if (row >= jagged.Length || column >= matrixRows || row < 0 || column < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (commandType == "Add")
                {
                    jagged[row][column] += value;
                }
                else if (commandType == "Subtract")
                {
                    jagged[row][column] -= value;
                }
            }

            ReadMatrix(jagged);
        }

        static void ReadMatrix(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int column = 0; column < jaggedArray[row].Length; column++)
                {
                    Console.Write($"{jaggedArray[row][column]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
