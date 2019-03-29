using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Post_Office
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('|');

            string firstPartPattern = @"([#$%*&])([A-Z])+(\1)";
            string secondPartPattern = @"(\d+):(\d{2})";

            Match startingLetters = Regex.Match(input[0], firstPartPattern);
            MatchCollection wordsLength = Regex.Matches(input[1], secondPartPattern);

            Dictionary<char, int> wordsRules = new Dictionary<char, int>();

            foreach (char letter in startingLetters.Value)
            {
                foreach (Match match in wordsLength)
                {
                    int intLetter = int.Parse(match.Groups[1].Value);
                    if (letter == (char)intLetter)
                    {
                        if (!wordsRules.ContainsKey(letter))
                        {
                            wordsRules.Add(letter, int.Parse(match.Groups[2].Value));
                        }
                    }
                }
            }

            string[] partThreeWords = input[2].Split();
            List<string> output = new List<string>();

            foreach (var kvp in wordsRules)
            {
                for (int i = 0; i < partThreeWords.Length; i++)
                {
                    string thirdPartPattern = @"(?<!.)[" + kvp.Key + @"][^ ]{" + kvp.Value + @"}(?!.)";

                    Match match = Regex.Match(partThreeWords[i], thirdPartPattern);

                    if (match.Value.Length > 0)
                    {
                        output.Add(match.Value);
                        break;
                    }
                }
            }

            foreach (var word in output)
            {
                Console.WriteLine(word);
            }
        }
    }
}
