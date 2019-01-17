using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int firstWord = random.Next(0, words.Length);
                int secondWord = random.Next(0, words.Length);

                string changer = words[firstWord];
                words[firstWord] = words[secondWord];
                words[secondWord] = changer;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words)); // "\n works for new lines too => string.Join("\n", words)
        }
    }
}
