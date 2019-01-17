namespace Decimal_to_Binary_Converter
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            Stack<int> remainderStack = new Stack<int>();

            if (decimalNumber == 0)
            {
                Console.Write(0);
            }
            else if (decimalNumber > 0)
            {
                while (decimalNumber > 0)
                {
                    remainderStack.Push(decimalNumber % 2);
                    decimalNumber /= 2;
                }
            }

            while (remainderStack.Count > 0)
            {
                Console.Write(remainderStack.Pop());
            }

            Console.WriteLine();
        }
    }
}
