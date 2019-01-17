namespace Parking_System
{
    using System;
    using System.Linq;

    public class ParkingSystem
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int columns = sizes[1];

            int[][] parking = new int[rows][];

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                int[] car = input.Split().Select(int.Parse).ToArray();

                int entryRow = car[0];
                int parkRow = car[1];
                int parkColumn = car[2];

                int steps = Math.Abs(entryRow - parkRow) + 1;

                if (parking[parkRow] == null)
                {
                    parking[parkRow] = new int[columns];
                }

                if (parking[parkRow][parkColumn] == 0)
                {
                    parking[parkRow][parkColumn] = 1;

                    Console.WriteLine(steps + parkColumn);
                }
                else
                {
                    for (int i = 1; ; i++)
                    {
                        int leftCell = parkColumn - i;
                        int rightCell = parkColumn + i;

                        if (leftCell < 1 && rightCell > columns - 1)
                        {
                            Console.WriteLine($"Row {parkRow} full");
                            break;
                        }
                        else if (leftCell > 0 && parking[parkRow][leftCell] == 0)
                        {
                            parking[parkRow][leftCell] = 1;
                            Console.WriteLine(steps + leftCell);
                            break;
                        }
                        else if (rightCell < columns && parking[parkRow][rightCell] == 0)
                        {
                            parking[parkRow][rightCell] = 1;
                            Console.WriteLine(steps + rightCell);
                            break;
                        }
                    }
                }
            }
        }
    }
}