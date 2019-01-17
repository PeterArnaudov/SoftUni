using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    public class Program
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexesWithBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < indexesWithBugs.Length; i++)
            {
                if (indexesWithBugs[i] >= fieldSize || indexesWithBugs[i] < 0) continue;
                int index = indexesWithBugs[i];
                field[index] = 1;
                index = 0;
            }

            while (true)
            {
                string command = Console.ReadLine();
                int indexOfBug = 0;
                int flyLength = 0;
                string direction = string.Empty;

                if (command == "end") break;
                else
                {
                    string[] commandIntoArray = command.Split();
                    indexOfBug = int.Parse(commandIntoArray[0]); //index of bug
                    flyLength = int.Parse(commandIntoArray[2]); //fly length
                    direction = commandIntoArray[1]; //direction: left/right

                    if (indexOfBug >= field.Length || indexOfBug < 0) continue;
                    if (fieldSize == 0) continue;
                    if (flyLength == 0) continue;

                    if (field[indexOfBug] == 1)
                    {
                        if (direction == "right")
                        {
                            field[indexOfBug] = 0;
                            if (flyLength > 0)
                            {
                                for (int i = indexOfBug + flyLength; i < field.Length; i += flyLength)
                                {
                                    if (field[i] == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        field[i] = 1;
                                        break;
                                    }
                                }
                            }
                            else // flyLength < 0
                            {
                                if (indexOfBug - flyLength >= 0 && indexOfBug - flyLength < field.Length)
                                {
                                    flyLength = Math.Abs(flyLength);
                                    for (int i = indexOfBug - flyLength; i > -1; i -= flyLength)
                                    {
                                        if (field[i] == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            field[i] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            field[indexOfBug] = 0;
                            if (flyLength > 0)
                            {
                                for (int i = indexOfBug - flyLength; i > -1; i -= flyLength)
                                {
                                    if (field[i] == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        field[i] = 1;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                flyLength = Math.Abs(flyLength);
                                for (int i = indexOfBug + flyLength; i < field.Length; i += flyLength)
                                {
                                    if (field[i] == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        field[i] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}