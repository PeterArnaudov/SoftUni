using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_big_number
{
    public class Program
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            string zeroes = string.Empty;
            string summed = string.Empty;

            string numberReversed = string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                numberReversed += number[i];
            }

            int firstNumber = (int)Char.GetNumericValue(numberReversed[0]) * multiplier;
            summed = firstNumber.ToString();

            for (int i = 1; i < numberReversed.Length; i++)
            {
                int multiplied = (int)Char.GetNumericValue(numberReversed[i]) * multiplier;
                zeroes += 0;
                string toAdd = multiplied + zeroes;

                summed = Sum(summed, toAdd);
            }

            if (summed.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(summed);
            }
        }

        public static string Sum(string numberOne, string numberTwo)
        {
            string numberOneReversed = string.Empty;
            string numberTwoReversed = string.Empty;

            for (int i = numberOne.Length - 1; i >= 0; i--)
            {
                numberOneReversed += numberOne[i];
            }

            for (int i = numberTwo.Length - 1; i >= 0; i--)
            {
                numberTwoReversed += numberTwo[i];
            }

            int commonLength = Math.Min(numberOneReversed.Length, numberTwoReversed.Length);
            string output = string.Empty;
            bool carry = false;

            for (int i = 0; i < commonLength; i++)
            {
                int digitOne = (int)Char.GetNumericValue(numberOneReversed[i]);
                int digitTwo = (int)Char.GetNumericValue(numberTwoReversed[i]);
                int sum = digitOne + digitTwo;

                if (carry)
                {
                    sum++;
                    carry = false;
                }

                if (sum >= 10)
                {
                    carry = true;
                    sum -= 10;
                }

                output += sum;
            }

            if (numberTwo.Length > numberOne.Length && !carry)
            {
                string extra = numberTwoReversed.Substring(commonLength);
                output += extra;
            }
            else if (numberTwo.Length > numberOne.Length && carry)
            {
                string extra = numberTwoReversed.Substring(commonLength);

                for (int i = 0; i < extra.Length; i++)
                {
                    int digitOne = (int)Char.GetNumericValue(extra[i]);

                    if (carry)
                    {
                        digitOne++;
                        carry = false;
                    }

                    if (digitOne >= 10)
                    {
                        carry = true;
                        digitOne -= 10;
                    }

                    output += digitOne;
                }

                if (carry)
                {
                    output += 1;
                }
            }

            output = output.TrimEnd('0');
            string outputReversed = string.Empty;

            for (int i = output.Length - 1; i >= 0; i--)
            {
                outputReversed += output[i];
            }

            return outputReversed;
        }
    }
}
