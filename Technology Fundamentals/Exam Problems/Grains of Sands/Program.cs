using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grains_of_Sands
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Mort")
                {
                    break;
                }

                string[] commandLine = input.Split();
                string command = commandLine[0];

                if (command == "Add")
                {
                    numbers = AddCommand(numbers, commandLine);
                }
                else if (command == "Remove")
                {
                    numbers = RemoveCommand(numbers, commandLine);
                }
                else if (command == "Replace")
                {
                    numbers = ReplaceCommand(numbers, commandLine);
                }
                else if (command == "Increase")
                {
                    numbers = IncreaseCommand(numbers, commandLine);
                }
                else if (command == "Collapse")
                {
                    numbers = CollapseCommand(numbers, commandLine);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        public static List<int> AddCommand(List<int> numbers, string[] command)
        {
            int number = int.Parse(command[1]);
            numbers.Add(number);
            return numbers;
        }

        public static List<int> RemoveCommand(List<int> numbers, string[] command)
        {
            int number = int.Parse(command[1]);

            if (numbers.Contains(number))
            {
                numbers.Remove(number);
            }
            else
            {
                if (numbers.Count > number && number >= 0)
                {
                    numbers.RemoveAt(number);
                }
            }

            return numbers;
        }

        public static List<int> ReplaceCommand(List<int> numbers, string[] command)
        {
            int number = int.Parse(command[1]);
            int replacement = int.Parse(command[2]);

            if (numbers.Contains(number))
            {
                int index = numbers.FindIndex(x => x == number);
                numbers[index] = replacement;
            }

            return numbers;
        }

        public static List<int> IncreaseCommand(List<int> numbers, string[] command)
        {
            int value = int.Parse(command[1]);

            if (numbers.Any(x => x >= value))
            {
                int increaseValue = numbers.Find(x => x >= value);
                numbers = numbers.Select(x => x + increaseValue).ToList();
            }
            else
            {
                int increaseValue = numbers.Last();
                numbers = numbers.Select(x => x + increaseValue).ToList();
            }

            return numbers;
        }

        public static List<int> CollapseCommand(List<int> numbers, string[] command)
        {
            int value = int.Parse(command[1]);

            numbers.RemoveAll(x => x < value);

            return numbers;
        }
    }
}