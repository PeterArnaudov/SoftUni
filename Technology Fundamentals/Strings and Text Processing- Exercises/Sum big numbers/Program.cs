using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_big_numbers
{
    public class Program
    {
        public static void Main()
        {
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();

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

            if (numberOne.Length > numberTwo.Length && !carry)
            {
                string extra = numberOneReversed.Substring(commonLength);
                output += extra;
            }
            else if (numberTwo.Length > numberOne.Length && !carry)
            {
                string extra = numberTwoReversed.Substring(commonLength);
                output += extra;
            }
            else if (numberOne.Length > numberTwo.Length && carry)
            {
                string extra = numberOneReversed.Substring(commonLength);

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

            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
        }
    }
}
