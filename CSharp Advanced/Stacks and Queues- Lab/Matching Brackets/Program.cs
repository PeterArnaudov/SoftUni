namespace Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<int> bracketsFinder = new Stack<int>();
            int openingBracketIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketsFinder.Push(i);
                }
                else if (input[i] == ')')
                {
                    openingBracketIndex = bracketsFinder.Pop();

                    Console.WriteLine(input.Substring(openingBracketIndex, i - openingBracketIndex + 1));
                }
            }
        }
    }
}
