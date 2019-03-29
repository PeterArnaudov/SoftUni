namespace JediGalaxy
{
    using System;
    using System.Linq;

    public class JediGalaxy
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int columns = sizes[1];

            int[][] galaxy = new int[rows][];

            for (int i = 0, number = 0; i < rows; i++)
            {
                galaxy[i] = new int[columns];
                for (int j = 0; j < columns; j++, number++)
                {
                    galaxy[i][j] = number;
                }
            }

            long stars = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Let the Force be with you")
                {
                    break;
                }

                int[] playerCoordinates = command.Split().Select(int.Parse).ToArray();
                int playerRow = playerCoordinates[0];
                int playerColumn = playerCoordinates[1];

                int[] evilCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int evilRow = evilCoordinates[0];
                int evilColumn = evilCoordinates[1];
                
                while (evilRow >= 0 && evilColumn >= 0)
                {
                    if (IsIndexValid(evilRow, evilColumn, rows, columns))
                    {
                        galaxy[evilRow][evilColumn] = 0;
                    }
                    evilRow--;
                    evilColumn--;
                }

                while (playerRow >= 0 && playerColumn < columns)
                {
                    if (IsIndexValid(playerRow, playerColumn, rows, columns))
                    {
                        stars += galaxy[playerRow][playerColumn];
                    }
                    playerRow--;
                    playerColumn++;
                }
            }

            Console.WriteLine(stars);
        }

        public static bool IsIndexValid(int row, int column, int rows, int columns)
        {
            return row >= 0 && row < rows && column >= 0 && column < columns;
        }
    }
}
