using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    public class Program
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                string commandType = command[0];

                if (commandType == "3:1")
                {
                    break;
                }

                if (commandType == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    input = MergeCommand(input, startIndex, endIndex);
                }
                else if (commandType == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    input = DivideCommand(input, index, partitions);
                }
            }

            Console.WriteLine(string.Join(" ", input));

        }
        public static List<string> MergeCommand(List<string> input, int startIndex, int endIndex)
        {
            if (endIndex > input.Count - 1 || endIndex < 0)
            {
                endIndex = input.Count - 1;
            }

            if (startIndex < 0 || startIndex > input.Count)
            {
                startIndex = 0;
            }

            string concatWord = string.Empty;

            for (int i = startIndex; i <= endIndex; i++)
            {
                concatWord += input[i];
            }

            input.RemoveRange(startIndex, endIndex - startIndex + 1);
            input.Insert(startIndex, concatWord);

            return input;
        }

        public static List<string> DivideCommand(List<string> input, int index, int partitions)
        {
            string word = input[index];
            List<string> divided = new List<string>();

            input.RemoveAt(index);

            int parts = word.Length / partitions;

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    divided.Add(word.Substring(i * parts));
                }
                else
                {
                    divided.Add(word.Substring(i * parts, parts));
                }
            }

            input.InsertRange(index, divided);

            return input;
        }
    }
}