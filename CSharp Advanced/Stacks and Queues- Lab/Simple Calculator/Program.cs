namespace Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] values = input.Split();

            Stack<string> calculatorStack = new Stack<string>(values);
            calculatorStack.Reverse();
            int result = 0;

            while (calculatorStack.Count > 1)
            {
                int number = int.Parse(calculatorStack.Pop());
                char sign = char.Parse(calculatorStack.Pop());

                if (sign == '+')
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }

            result += int.Parse(calculatorStack.Pop());

            Console.WriteLine(result);
        }
    }
}
