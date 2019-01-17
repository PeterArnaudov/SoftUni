using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Manipulation_Advanced
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "Contains")
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
