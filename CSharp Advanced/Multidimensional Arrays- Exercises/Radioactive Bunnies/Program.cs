namespace Radioactive_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            //Input
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int columns = sizes[1];

            char[,] field = new char[rows, columns];

            //Fill the field and get the player's initial coordinates
            int playerRow = 0;
            int playerColumn = 0;

            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();
                for (int column = 0; column < columns; column++)
                {
                    if (currentRow[column] == 'P')
                    {
                        playerRow = row;
                        playerColumn = column;
                    }

                    field[row, column] = currentRow[column];
                }
            }

            string steps = Console.ReadLine();

            field[playerRow, playerColumn] = '.';

            for (int i = 0; i < steps.Length; i++)
            {
                //Player steps functionality
                int previousPlayerRow = playerRow;
                int previousPlayerColumn = playerColumn;


                if (steps[i] == 'L')
                {
                    playerColumn--;
                }
                else if (steps[i] == 'R')
                {
                    playerColumn++;
                }
                else if (steps[i] == 'U')
                {
                    playerRow--;
                }
                else if (steps[i] == 'D')
                {
                    playerRow++;
                }

                //Check for bunnies and get their coordinates
                Queue<int> bunniesPositions = new Queue<int>();

                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        if (field[row, column] == 'B')
                        {
                            bunniesPositions.Enqueue(row);
                            bunniesPositions.Enqueue(column);
                        }
                    }
                }

                while (bunniesPositions.Count != 0)
                {
                    int bunnyRow = bunniesPositions.Dequeue();
                    int bunnyColumn = bunniesPositions.Dequeue();

                    //spread bunny up
                    if (bunnyRow - 1 >= 0)
                    {
                        field[bunnyRow - 1, bunnyColumn] = 'B';
                    }

                    //spread bunny down
                    if (bunnyRow + 1 < rows)
                    {
                        field[bunnyRow + 1, bunnyColumn] = 'B';
                    }

                    //spread bunny left
                    if (bunnyColumn - 1 >= 0)
                    {
                        field[bunnyRow, bunnyColumn - 1] = 'B';
                    }

                    //spread bunny right
                    if (bunnyColumn + 1 < columns)
                    {
                        field[bunnyRow, bunnyColumn + 1] = 'B';
                    }
                }

                //check if the player escaped the field after every step
                if (playerRow < 0 || playerRow >= rows || playerColumn < 0 || playerColumn >= columns)
                {
                    PrintField(field);
                    Console.WriteLine($"won: {previousPlayerRow} {previousPlayerColumn}");
                    break;
                }

                //check if the player has died after each step and bunny spread
                if (field[playerRow, playerColumn] == 'B')
                {
                    PrintField(field);
                    Console.WriteLine($"dead: {playerRow} {playerColumn}");
                    break;
                }
            }
        }

        public static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int column = 0; column < field.GetLength(1); column++)
                {
                    Console.Write(field[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}