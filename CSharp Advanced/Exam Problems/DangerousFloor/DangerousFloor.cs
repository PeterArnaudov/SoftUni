namespace DangerousFloor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DangerousFloor
    {
        public static void Main()
        {
            char[][] board = new char[8][];

            for (int i = 0; i < 8; i++)
            {
                board[i] = Console.ReadLine().Split(',').Select(char.Parse).ToArray();
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                char pieceType = input[0];
                int initialRow = (int)Char.GetNumericValue(input[1]);
                int initialColumn = (int)Char.GetNumericValue(input[2]);
                int moveRow = (int)Char.GetNumericValue(input[4]);
                int moveColumn = (int)Char.GetNumericValue(input[5]);

                if (board[initialRow][initialColumn] != pieceType)
                {
                    Console.WriteLine("There is no such a piece!");
                }
                else if (!IsValidMove(pieceType, initialRow, initialColumn, moveRow, moveColumn))
                {
                    Console.WriteLine("Invalid move!");
                }
                else if (IsOutOfBoard(moveRow, moveColumn))
                {
                    Console.WriteLine("Move go out of board!");
                }
                else
                {
                    board[initialRow][initialColumn] = 'x';
                    board[moveRow][moveColumn] = pieceType;
                }
            }
        }

        public static bool IsValidMove(char pieceType, int initialRow, int initialColumn, int moveRow, int moveColumn)
        {
            if (pieceType == 'K')
            {
                int[] move = new int[] { moveRow, moveColumn };

                if (new int[] { initialRow - 1, initialColumn - 1 }.SequenceEqual(move) ||
                    new int[] { initialRow - 1, initialColumn }.SequenceEqual(move) ||
                    new int[] { initialRow - 1, initialColumn + 1 }.SequenceEqual(move) ||
                    new int[] { initialRow, initialColumn - 1 }.SequenceEqual(move) ||
                    new int[] { initialRow, initialColumn + 1 }.SequenceEqual(move) ||
                    new int[] { initialRow + 1, initialColumn - 1 }.SequenceEqual(move) ||
                    new int[] { initialRow + 1, initialColumn }.SequenceEqual(move) ||
                    new int[] { initialRow + 1, initialColumn + 1 }.SequenceEqual(move))
                {
                    return true;
                }
            }
            else if (pieceType == 'R')
            {
                if (initialRow == moveRow || initialColumn == moveColumn)
                {
                    return true;
                }
            }
            else if (pieceType == 'B')
            {
                int rowDifference = Math.Abs(initialRow - moveRow);
                int columnDifference = Math.Abs(initialColumn - moveColumn);

                if (rowDifference == columnDifference)
                {
                    return true;
                }
            }
            else if (pieceType == 'Q')
            {
                int rowDifference = Math.Abs(initialRow - moveRow);
                int columnDifference = Math.Abs(initialColumn - moveColumn);

                if (rowDifference == columnDifference)
                {
                    return true;
                }
                else if (initialRow == moveRow || initialColumn == moveColumn)
                {
                    return true;
                }
            }
            else if (pieceType == 'P')
            {
                if (initialRow - 1 == moveRow)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsOutOfBoard(int moveRow, int moveColumn)
        {
            if (moveRow < 0 || moveRow >= 8 || moveColumn < 0 || moveColumn >= 8)
            {
                return true;
            }

            return false;
        }
    }
}
