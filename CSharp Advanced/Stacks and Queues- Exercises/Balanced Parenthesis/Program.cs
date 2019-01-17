namespace Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Queue<char> parenthesisQueue = new Queue<char>();

            foreach (var ch in input)
            {
                parenthesisQueue.Enqueue(ch);
            }

            if (parenthesisQueue.Count % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            int count = parenthesisQueue.Count / 2;

            while (count != 0)
            {
                count--;
                char current = parenthesisQueue.Dequeue();
                char opposite = ' ';

                if (current == '(')
                {
                    opposite = ')';
                }
                else if (current == '[')
                {
                    opposite = ']';
                }
                else if (current == '{')
                {
                    opposite = '}';
                }
                else if (current == ')') //although ")" and those below shouldn't be considered as opening brackets
                {
                    opposite = '(';
                }
                else if (current == ']')
                {
                    opposite = '[';
                }
                else if (current == '}')
                {
                    opposite = '{';
                }

                for (int j = 0; j < parenthesisQueue.Count; j++)
                {
                    char next = parenthesisQueue.Dequeue();

                    if (next == opposite && (j == parenthesisQueue.Count || j == 0))
                    {
                        break;
                    }

                    parenthesisQueue.Enqueue(next);
                }
            }

            if (parenthesisQueue.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
