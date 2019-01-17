namespace Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            string[] inputWords = input.Split(" | ");

            foreach (var inputWord in inputWords)
            {
                string[] pair = inputWord.Split(": ");
                string word = pair[0];
                string definition = pair[1];

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }

                words[word].Add(definition);
            }

            string[] printWords = Console.ReadLine().Split(" | ");

            foreach (var word in printWords)
            {
                if (words.ContainsKey(word))
                {
                    Console.WriteLine($"{word}");
                    foreach (var item in words[word].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($"-{item}");
                    }
                }
            }

            string command = Console.ReadLine();

            if (command == "End")
            {
                return;
            }
            else if (command == "List")
            {
                foreach (var word in words.OrderBy(x => x.Key))
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
