using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string stringOne = input[0];
            string stringTwo = input[1];

            int multiplied = 0;

            for (int i = Math.Min(stringOne.Length, stringTwo.Length) - 1; i >= 0; i--)
            {
                multiplied += stringOne[i] * stringTwo[i];
                stringOne = stringOne.Remove(i, 1);
                stringTwo = stringTwo.Remove(i, 1);
            }

            if (stringOne.Length > 0)
            {
                for (int i = 0; i < stringOne.Length; i++)
                {
                    multiplied += stringOne[i];
                }
            }
            else if (stringTwo.Length > 0)
            {
                for (int i = 0; i < stringTwo.Length; i++)
                {
                    multiplied += stringTwo[i];
                }
            }

            Console.WriteLine(multiplied);
        }
    }
}
