using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            int points = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                    points += 1;
                else if (word[i] == 'e')
                    points += 2;
                else if (word[i] == 'i')
                    points += 3;
                else if (word[i] == 'o')
                    points += 4;
                else if (word[i] == 'u')
                    points += 5;
            }

            Console.WriteLine(points);
        }
    }
}
