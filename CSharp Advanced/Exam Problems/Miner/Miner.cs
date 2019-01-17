namespace Miner
{
    using System;
    using System.Linq;

    public class Miner
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[] moves = Console.ReadLine().Split();

            char[,] field = new char[size, size];
            int coals = 0;

            int playerRow = 0;
            int playerColumn = 0;

            for (int i = 0; i < size; i++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int j = 0; j < size; j++)
                {
                    field[i, j] = currentRow[j];

                    if (currentRow[j] == 'c')
                    {
                        coals++;
                    }
                    else if (currentRow[j] == 's')
                    {
                        playerRow = i;
                        playerColumn = j;
                    }
                }
            }

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == "left") //column - 1
                {
                    if (IsInside(playerRow, playerColumn - 1, size))
                    {
                        if (field[playerRow, playerColumn - 1] == 'c')
                        {
                            coals--;
                            field[playerRow, playerColumn - 1] = '*';
                            playerColumn--;
                        }
                        else if (field[playerRow, playerColumn - 1] == 'e')
                        {
                            playerColumn--;
                            Console.WriteLine($"Game over! ({playerRow}, {playerColumn})");
                            return;
                        }
                        else
                        {
                            playerColumn--;
                        }
                    }
                }
                else if (moves[i] == "right") //column + 1
                {
                    if (IsInside(playerRow, playerColumn + 1, size))
                    {
                        if (field[playerRow, playerColumn + 1] == 'c')
                        {
                            coals--;
                            field[playerRow, playerColumn + 1] = '*';
                            playerColumn++;
                        }
                        else if (field[playerRow, playerColumn + 1] == 'e')
                        {
                            playerColumn++;
                            Console.WriteLine($"Game over! ({playerRow}, {playerColumn})");
                            return;
                        }
                        else
                        {
                            playerColumn++;
                        }
                    }
                }
                else if (moves[i] == "up") //row - 1
                {
                    if (IsInside(playerRow - 1, playerColumn, size))
                    {
                        if (field[playerRow - 1, playerColumn] == 'c')
                        {
                            coals--;
                            field[playerRow - 1, playerColumn] = '*';
                            playerRow--;
                        }
                        else if (field[playerRow - 1, playerColumn] == 'e')
                        {
                            playerRow--;
                            Console.WriteLine($"Game over! ({playerRow}, {playerColumn})");
                            return;
                        }
                        else
                        {
                            playerRow--;
                        }
                    }
                }
                else if (moves[i] == "down") //row + 1
                {
                    if (IsInside(playerRow + 1, playerColumn, size))
                    {
                        if (field[playerRow + 1, playerColumn] == 'c')
                        {
                            coals--;
                            field[playerRow + 1, playerColumn] = '*';
                            playerRow++;
                        }
                        else if (field[playerRow + 1, playerColumn] == 'e')
                        {
                            playerRow++;
                            Console.WriteLine($"Game over! ({playerRow}, {playerColumn})");
                            return;
                        }
                        else
                        {
                            playerRow++;
                        }
                    }
                }

                if (coals == 0)
                {
                    Console.WriteLine($"You collected all coals! ({playerRow}, {playerColumn})");
                    return;
                }
            }

            Console.WriteLine($"{coals} coals left. ({playerRow}, {playerColumn})");
        }

        public static bool IsInside(int playerRow, int playerColumn, int size)
        {
            return playerRow >= 0 && playerRow < size && playerColumn >= 0 && playerColumn < size;
        }
    }
}
