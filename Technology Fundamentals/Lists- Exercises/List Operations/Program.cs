using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Operations
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) >= numbers.Count || int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) >= numbers.Count || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Shift" && command[1] == "left")
                {
                    numbers = RollLeftCommand(numbers, int.Parse(command[2]));
                }
                else if (command[0] == "Shift" && command[1] == "right")
                {
                    numbers = RollRightCommand(numbers, int.Parse(command[2]));
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        public static List<int> RollLeftCommand(List<int> afterRollLeft, int count)
        {
            int inputLength = afterRollLeft.Count();

            for (int i = 0; i < count % inputLength; i++)
            {
                int element = afterRollLeft[0];
                afterRollLeft.RemoveAt(0);
                afterRollLeft.Add(element);
            }

            return afterRollLeft;
        }

        public static List<int> RollRightCommand(List<int> afterRollRight, int count)
        {
            int inputLength = afterRollRight.Count();

            for (int i = 0; i < count % inputLength; i++)
            {
                int element = afterRollRight[afterRollRight.Count - 1];
                afterRollRight.RemoveAt(afterRollRight.Count - 1);
                afterRollRight.Insert(0, element);
            }

            return afterRollRight;
        }
    }
}
