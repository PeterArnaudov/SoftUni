using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Number
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string numberAsString = $"{i}";
                PrintMasterNumbers(numberAsString);
            }
        }

        public static void PrintMasterNumbers(string numberAsString)
        {
            if (SumOfDigits(numberAsString) % 8 == 0 && CheckIfContainsOddNumber(numberAsString) == true)
            {
                Console.WriteLine(numberAsString);
            }
        }

        public static int SumOfDigits(string numberAsString)
        {
            int sum = 0;
            for (int i = 0; i < numberAsString.Length; i++)
            {
                int number = numberAsString[i];
                sum += number;
            }
            return sum;
        }

        public static bool CheckIfContainsOddNumber(string numberAsString)
        {
            bool containsOddNumber = false;

            for (int i = 0; i < numberAsString.Length; i++)
            {
                if (numberAsString[i] % 2 != 0)
                {
                    containsOddNumber = true;
                    break;
                }
            }

            return containsOddNumber;
        }
    }
}
