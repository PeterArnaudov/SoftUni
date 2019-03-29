using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Manipulation_Basics
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

                if (command[0] == "Add")
                {
                    numbers = AddCommand(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    numbers = RemoveCommand(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers = RemoveAtCommand(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    numbers = InsertCommand(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
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
    }
}