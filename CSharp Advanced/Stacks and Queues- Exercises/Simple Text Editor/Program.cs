namespace Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int operations = int.Parse(Console.ReadLine());
            Stack<int> changeTypes = new Stack<int>();
            Stack<string> changes = new Stack<string>();
            string text = string.Empty;

            for (int i = 0; i < operations; i++)
            {
                string[] command = Console.ReadLine().Split();

                int commandType = int.Parse(command[0]);

                if (commandType == 1)
                {
                    changeTypes.Push(1);
                    changes.Push(command[1]);
                    text += command[1];
                }
                else if (commandType == 2)
                {
                    changeTypes.Push(2);
                    changes.Push(text.Substring(text.Length - int.Parse(command[1])));
                    text = text.Substring(0, text.Length - int.Parse(command[1]));
                }
                else if (commandType == 3)
                {
                    Console.WriteLine(text[int.Parse(command[1]) - 1]);
                }
                else if (commandType == 4)
                {
                    if (changeTypes.Peek() == 1)
                    {
                        text = text.Substring(0, text.Length - changes.Pop().Length);
                    }
                    else if (changeTypes.Peek() == 2)
                    {
                        text += changes.Pop();
                    }

                    changeTypes.Pop();
                }
            }
        }
    }
}
