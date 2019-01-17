namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        public static void Main()
        {
            string path = "../../../";
            string fileName = "words.txt";
            path = Path.Combine(path, fileName);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (!wordsCount.ContainsKey(line))
                    {
                        wordsCount.Add(line, 0);
                    }

                    line = reader.ReadLine();
                }
            }

            path = "../../../";
            fileName = "text.txt";
            path = Path.Combine(path, fileName);

            using (StreamReader reader = new StreamReader(path))
            {
                MatchCollection words = Regex.Matches(reader.ReadToEnd(), @"[a-zA-Z]+");

                foreach (Match word in words)
                {
                    string currentWord = word.Value.ToLower();

                    if (wordsCount.ContainsKey(currentWord))
                    {
                        wordsCount[currentWord]++;
                    }
                }
            }

            string outputFileName = "results.txt";

            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
