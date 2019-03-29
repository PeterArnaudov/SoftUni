using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Manipulation_Complete
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool changed = false;

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    if (changed)
                    {
                        Console.WriteLine(string.Join(" ", numbers));
                    }
                    break;
                }

                if (command[0] == "Add")
                {
                    numbers = AddCommand(numbers, int.Parse(command[1]));
                    changed = true;
                }

                else if (command[0] == "Remove")
                {
                    numbers = RemoveCommand(numbers, int.Parse(command[1]));
                    changed = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers = RemoveAtCommand(numbers, int.Parse(command[1]));
                    changed = true;
                }
                else if (command[0] == "Insert")
                {
                    numbers = InsertCommand(numbers, int.Parse(command[1]), int.Parse(command[2]));
                    changed = true;
                }
                else if (command[0] == "Contains")
                {
                    Contains(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "PrintEven")
                {
                    PrintEvenNumbers(numbers);
                }
                else if (command[0] == "PrintOdd")
                {
                    PrintOddNumbers(numbers);
                }
                else if (command[0] == "GetSum")
                {
                    PrintSum(numbers);
                }
                else if (command[0] == "Filter")
                {
                    PrintFilteredNumbers(numbers, command[1], int.Parse(command[2]));
                }
            }
        }

        public static List<int> AddCommand(List<int> numbers, int numberToAdd)
        {
            numbers.Add(numberToAdd);
            return numbers;
        }

        public static List<int> RemoveCommand(List<int> numbers, int numberToRemove)
        {
            numbers.Remove(numberToRemove);
            return numbers;
        }

        public static List<int> RemoveAtCommand(List<int> numbers, int indexToRemove)
        {
            numbers.RemoveAt(indexToRemove);
            return numbers;
        }

        public static List<int> InsertCommand(List<int> numbers, int numberToInsert, int atIndex)
        {
            numbers.Insert(atIndex, numberToInsert);
            return numbers;
        }

        public static void Contains(List<int> numbers, int number)
        {
            if (numbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        public static void PrintEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", evenNumbers));
        }

        public static void PrintOddNumbers(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", oddNumbers));
        }

        public static void PrintSum(List<int> numbers)
        {
            Console.WriteLine(numbers.Sum());
        }

        public static void PrintFilteredNumbers(List<int> numbers, string condition, int number)
        {
            List<int> filteredNumbers = new List<int>();

            if (condition == "<")
            {
                for (int i = 0; i < numbers.Count(); i++)
                {
                    if (numbers[i] < number)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
            }
            else if (condition == ">")
            {
                for (int i = 0; i < numbers.Count(); i++)
                {
                    if (numbers[i] > number)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count(); i++)
                {
                    if (numbers[i] >= number)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < numbers.Count(); i++)
                {
                    if (numbers[i] <= number)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}