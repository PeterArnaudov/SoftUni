using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main()
        {
            // 90/100

            string[] arrayOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrayTwo = Console.ReadLine().Split(' ').ToArray();

            int equalLeftWords = 0;
            int equalRightWords = 0;
            int arrayOneLength = arrayOne.Length - 1;
            int arrayTwoLength = arrayTwo.Length - 1;

            if (arrayOne.Length > arrayTwo.Length)
            {
                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                        equalLeftWords++;
                }
                for (int i = arrayOne.Length - 1; arrayTwoLength > 0; i--)
                {
                    if (arrayOne[i] == arrayTwo[arrayTwoLength])
                        equalRightWords++;
                    arrayTwoLength--;
                }

                if (equalLeftWords >= equalRightWords)
                    Console.WriteLine(equalLeftWords);
                else if (equalLeftWords < equalRightWords)
                    Console.WriteLine(equalRightWords);
                else if (equalLeftWords == 0 && equalRightWords == 0)
                    Console.WriteLine(0);
            }
            else if (arrayOne.Length <= arrayTwo.Length)
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                        equalLeftWords++;
                }
                for (int i = arrayTwo.Length - 1; arrayOneLength > 0; i--)
                {
                    if (arrayOne[arrayOneLength] == arrayTwo[i])
                        equalRightWords++;
                    arrayOneLength--;
                }

                if (equalLeftWords >= equalRightWords)
                    Console.WriteLine(equalLeftWords);
                else if (equalLeftWords < equalRightWords)
                    Console.WriteLine(equalRightWords);
                else if (equalLeftWords == 0 && equalRightWords == 0)
                    Console.WriteLine(0);
            }
        }
    }
}
