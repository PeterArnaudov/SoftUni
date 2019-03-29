using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    public class Program
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index >= input.Count() || index < 0) //(remove the -1 ?
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    input = ExchangeCommand(input, index);
                }
                else if (command[0] == "max" && command[1] == "even")
                {
                    PrintEvenMaxIndex(input);
                }
                else if (command[0] == "max" && command[1] == "odd")
                {
                    PrintOddMaxIndex(input);
                }
                else if (command[0] == "min" && command[1] == "even")
                {
                    PrintEvenMinIndex(input);
                }
                else if (command[0] == "min" && command[1] == "odd")
                {
                    PrintOddMinIndex(input);
                }
                else if (command[0] == "first" && command[2] == "even")
                {
                    PrintFirstEvenNumbers(input, int.Parse(command[1]));
                }
                else if (command[0] == "first" && command[2] == "odd")
                {
                    PrintFirstOddNumbers(input, int.Parse(command[1]));
                }
                else if (command[0] == "last" && command[2] == "even")
                {
                    PrintLastEvenNumbers(input, int.Parse(command[1]));
                }
                else if (command[0] == "last" && command[2] == "odd")
                {
                    PrintLastOddNumbers(input, int.Parse(command[1]));
                }
                else if (command[0] == "end")
                {
                    break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        public static List<int> ExchangeCommand(List<int> afterExchange, int index)
        {
            List<int> removed = new List<int>();


            if (index == 0)
            {
                int firstElement = afterExchange[0];
                for (int i = 0; i < afterExchange.Count() - 1; i++)
                {
                    afterExchange[i] = afterExchange[i + 1];
                }
                afterExchange[afterExchange.Count() - 1] = firstElement;
                return afterExchange;
            }

            for (int i = 0; i <= index; i++)
                removed.Add(afterExchange[i]);

            afterExchange.RemoveRange(0, index + 1);

            for (int i = 0; i < removed.Count(); i++)
            {
                afterExchange.Add(removed[i]);
            }

            return afterExchange;
        }

        public static void PrintEvenMaxIndex(List<int> input)
        {
            int max = int.MinValue;
            int maxIndex = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] % 2 == 0 && input[i] >= max)
                {
                    max = input[i];
                    maxIndex = i;
                }
            }

            if (max == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        public static void PrintOddMaxIndex(List<int> input)
        {
            int max = int.MinValue;
            int maxIndex = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] % 2 != 0 && input[i] >= max)
                {
                    max = input[i];
                    maxIndex = i;
                }
            }

            if (max == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        public static void PrintEvenMinIndex(List<int> input)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] % 2 == 0 && input[i] <= min)
                {
                    min = input[i];
                    minIndex = i;
                }
            }

            if (min == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        public static void PrintOddMinIndex(List<int> input)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] % 2 != 0 && input[i] <= min)
                {
                    min = input[i];
                    minIndex = i;
                }
            }

            if (min == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        public static void PrintFirstEvenNumbers(List<int> input, int count)
        {
            List<int> firstEvenNumbers = new List<int>();
            int numbersFound = 0;

            if (count > input.Count())
            {
                Console.WriteLine("Invalid count");
                return;
            }

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] % 2 == 0)
                {
                    numbersFound++;
                    firstEvenNumbers.Add(input[i]);

                    if (numbersFound == count)
                    {
                        break;
                    }
                }
            }

            if (numbersFound == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", firstEvenNumbers)}]");
            }
        }

        public static void PrintFirstOddNumbers(List<int> input, int count)
        {
            List<int> firstOddNumbers = new List<int>();
            int numbersFound = 0;

            if (count > input.Count())
            {
                Console.WriteLine("Invalid count");
                return;
            }

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] % 2 != 0)
                {
                    numbersFound++;
                    firstOddNumbers.Add(input[i]);

                    if (numbersFound == count)
                    {
                        break;
                    }
                }
            }

            if (numbersFound == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", firstOddNumbers)}]");
            }
        }

        public static void PrintLastEvenNumbers(List<int> input, int count)
        {
            List<int> lastEvenNumbers = new List<int>();
            int numbersFound = 0;

            if (count > input.Count())
            {
                Console.WriteLine("Invalid count");
                return;
            }

            for (int i = input.Count() - 1; i >= 0; i--)
            {
                if (input[i] % 2 == 0)
                {
                    numbersFound++;
                    lastEvenNumbers.Add(input[i]);

                    if (numbersFound == count)
                    {
                        break;
                    }
                }
            }

            lastEvenNumbers.Reverse();

            if (numbersFound == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", lastEvenNumbers)}]");
            }
        }

        public static void PrintLastOddNumbers(List<int> input, int count)
        {
            List<int> lastOddNumbers = new List<int>();
            int numbersFound = 0;

            if (count > input.Count())
            {
                Console.WriteLine("Invalid count");
                return;
            }

            for (int i = input.Count() - 1; i >= 0; i--)
            {
                if (input[i] % 2 != 0)
                {
                    numbersFound++;
                    lastOddNumbers.Add(input[i]);

                    if (numbersFound == count)
                    {
                        break;
                    }
                }
            }

            lastOddNumbers.Reverse();

            if (numbersFound == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", lastOddNumbers)}]");
            }
        }
    }
}
