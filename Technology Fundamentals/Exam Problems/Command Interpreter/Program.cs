using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Interpreter
{
    public class Program
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "end") break;

                //command[0] = commandType
                int start = 0;
                int count = 0;

                if (command[0] == "reverse" || command[0] == "sort")
                {
                    start = int.Parse(command[2]);
                    count = int.Parse(command[4]);
                    if (start < 0 || (start + count) > input.Count || count < 0 || start >= input.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                }
                else
                {
                    count = int.Parse(command[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                }

                if (command[0] == "rollLeft")
                    input = RollLeftCommand(input, count);
                else if (command[0] == "rollRight")
                    input = RollRightCommand(input, count);
                else if (command[0] == "reverse")
                    input = ReverseCommand(input, start, count);
                else if (command[0] == "sort")
                    input = SortCommand(input, start, count);
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        public static List<string> RollLeftCommand(List<string> afterRollLeft, int count)
        {
            int inputLength = afterRollLeft.Count();

            for (int i = 0; i < count % inputLength; i++)
            {
                string element = afterRollLeft[0];
                afterRollLeft.RemoveAt(0);
                afterRollLeft.Add(element);
            }

            return afterRollLeft;
        }

        public static List<string> RollRightCommand(List<string> afterRollRight, int count)
        {
            int inputLength = afterRollRight.Count();

            for (int i = 0; i < count % inputLength; i++)
            {
                string element = afterRollRight[afterRollRight.Count - 1];
                afterRollRight.RemoveAt(afterRollRight.Count - 1);
                afterRollRight.Insert(0, element);
            }

            return afterRollRight;
        }

        public static List<string> ReverseCommand(List<string> afterReverse, int start, int count)
        {
            List<string> removed = new List<string>();

            removed = afterReverse.Skip(start).Take(count).Reverse().ToList();
            afterReverse.RemoveRange(start, count);
            afterReverse.InsertRange(start, removed);

            return afterReverse;
        }

        public static List<string> SortCommand(List<string> afterSort, int start, int count)
        {
            List<string> removed = new List<string>();

            removed = afterSort.Skip(start).Take(count).OrderBy(str => str).ToList();
            afterSort.RemoveRange(start, count);
            afterSort.InsertRange(start, removed);

            return afterSort;
        }
    }
}
