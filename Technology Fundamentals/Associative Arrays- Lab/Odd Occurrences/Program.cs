using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> wordsOccurence = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (wordsOccurence.ContainsKey(input[i]))
                {
                    wordsOccurence[input[i]]++;
                }
                else
                {
                    wordsOccurence.Add(input[i], 1);
                }
            }

            List<string> output = new List<string>();

            foreach (var pair in wordsOccurence)
            {
                if (pair.Value % 2 != 0)
                {
                    output.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
