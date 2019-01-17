using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Synonyms
{
    public class Program
    {
        public static void Main()
        {
            int numberOfPairs = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonymDinctionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfPairs; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymDinctionary.ContainsKey(word))
                {
                    synonymDinctionary.Add(word, new List<string>());
                }

                synonymDinctionary[word].Add(synonym);
            }

            foreach (var word in synonymDinctionary)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", synonymDinctionary[word.Key])}");
            }
        }
    }
}