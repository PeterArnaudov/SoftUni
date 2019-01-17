using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                string decryptPattern = @"[sStTaArR]";
                int decryptKeyValue = 0;

                MatchCollection decryptValueLetters = Regex.Matches(input, decryptPattern);

                foreach (Match letters in decryptValueLetters)
                {
                    decryptKeyValue++;
                }

                string decrypted = string.Empty;

                for (int j = 0; j < input.Length; j++)
                {
                    decrypted += Convert.ToChar(Convert.ToInt32(input[j]) - decryptKeyValue);
                }

                string pattern = @"@([a-zA-Z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!([AD])![^@\-!:>]*->(\d+)";

                Match match = Regex.Match(decrypted, pattern);

                if (match.Groups[1].Value.Length > 0 && match.Groups[2].Value.Length > 0 && match.Groups[3].Value.Length > 0 && match.Groups[4].Value.Length > 0)
                {
                    if (match.Groups[3].Value == "A")
                    {
                        attackedPlanets.Add(match.Groups[1].Value);
                    }
                    else if (match.Groups[3].Value == "D")
                    {
                        destroyedPlanets.Add(match.Groups[1].Value);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
