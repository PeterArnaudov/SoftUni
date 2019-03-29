namespace Sneaking
{
    using System;
    using System.Linq;

    public class Sneaking
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] room = new char[rows][];

            int playerRow = 0;
            int playerColumn = 0;
            int winRow = 0;
            int winColumn = 0;

            for (int i = 0; i < rows; i++)
            {
                string currentRow = Console.ReadLine();

                room[i] = new char[currentRow.Length];

                for (int j = 0; j < currentRow.Length; j++)
                {
                    room[i][j] = currentRow[j];

                    if (currentRow[j] == 'S')
                    {
                        playerRow = i;
                        playerColumn = j;
                    }
                    else if (currentRow[j] == 'N')
                    {
                        winRow = i;
                        winColumn = j;
                    }
                }
            }

            string moves = Console.ReadLine();

            for (int i = 0; i < moves.Length; i++)
            {
                room = MoveEnemies(room);

                if (IsPlayerKilled(room, playerRow, playerColumn))
                {
                    Console.WriteLine($"Sam died at {playerRow}, {playerColumn}");
                    room[playerRow][playerColumn] = 'X';
                    break;
                }

                room = MovePlayer(room, moves[i], playerRow, playerColumn);
                playerRow = MovePlayer(moves[i], playerRow, playerColumn)[0];
                playerColumn = MovePlayer(moves[i], playerRow, playerColumn)[1];

                if (IsWin(playerRow, winRow))
                {
                    Console.WriteLine("Nikoladze killed!");
                    room[winRow][winColumn] = 'X';
                    break;
                }
            }

            PrintRoom(room);
        }

        public static char[][] MoveEnemies(char[][] room)
        {
            char[][] updatedRoom = room;

            for (int row = 0; row < updatedRoom.Length; row++)
            {
                for (int column = 0; column < updatedRoom[row].Length; column++)
                {
                    if (updatedRoom[row][column] == 'b')
                    {
                        if (column + 1 == updatedRoom[row].Length)
                        {
                            updatedRoom[row][column] = 'd';
                            break;
                        }
                        else
                        {
                            updatedRoom[row][column] = '.';
                            updatedRoom[row][column + 1] = 'b';
                            break;
                        }
                    }
                    else if (updatedRoom[row][column] == 'd')
                    {
                        if (column - 1 == -1)
                        {
                            updatedRoom[row][column] = 'b';
                            break;
                        }
                        else
                        {
                            updatedRoom[row][column] = '.';
                            updatedRoom[row][column - 1] = 'd';
                            break;
                        }
                    }
                }
            }

            return updatedRoom;
        }

        public static bool IsPlayerKilled(char[][] room, int playerRow, int playerColumn)
        {
            int enemyColumn = 0;
            char enemyType = '.';

            for (int column = 0; column < room[playerRow].Length; column++)
            {
                if (room[playerRow][column] == 'b' || room[playerRow][column] == 'd')
                {
                    enemyColumn = column;
                    enemyType = room[playerRow][column];
                    break;
                }
            }

            if (enemyType == 'b')
            {
                if (enemyColumn < playerColumn)
                {
                    return true;
                }
            }
            else if (enemyType == 'd')
            {
                if (enemyColumn > playerColumn)
                {
                    return true;
                }
            }

            return false;
        }

        public static char[][] MovePlayer(char[][] room, char direction, int playerRow, int playerColumn)
        {
            if (direction == 'U')
            {
                room[playerRow][playerColumn] = '.';
                room[playerRow - 1][playerColumn] = 'S';
            }
            else if (direction == 'D')
            {
                room[playerRow][playerColumn] = '.';
                room[playerRow + 1][playerColumn] = 'S';
            }
            else if (direction == 'L')
            {
                room[playerRow][playerColumn] = '.';
                room[playerRow][playerColumn - 1] = 'S';
            }
            else if (direction == 'R')
            {
                room[playerRow][playerColumn] = '.';
                room[playerRow][playerColumn + 1] = 'S';
            }
            else if (direction == 'W')
            {
                //DO NOTHING
            }

            return room;
        }

        public static int[] MovePlayer(char direction, int playerRow, int playerColumn)
        {
            if (direction == 'U')
            {
                playerRow--;
            }
            else if (direction == 'D')
            {
                playerRow++;
            }
            else if (direction == 'L')
            {
                playerColumn--;
            }
            else if (direction == 'R')
            {
                playerColumn++;
            }

            return new int[] { playerRow, playerColumn };
        }

        public static bool IsWin(int playerRow, int winRow)
        {
            if (playerRow == winRow)
            {
                return true;
            }

            return false;
        }

        public static void PrintRoom(char[][] room)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int column = 0; column < room[row].Length; column++)
                {
                    Console.Write(room[row][column]);
                }
                Console.WriteLine();
            }
        }
    }
}
