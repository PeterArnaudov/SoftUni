namespace CryptoBlockchain
{
    using System;
    using System.Text.RegularExpressions;

    public class CryptoBlockchain
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            string input = string.Empty;
            string output = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                input += Console.ReadLine();
            }

            MatchCollection blocks = Regex.Matches(input, @"([\[{])([^\]}]+)([\]}])");
            
            for (int i = 0; i < blocks.Count; i++)
            {
                if ((blocks[i].Groups[1].Value == "{" && blocks[i].Groups[3].Value == "}")
                    || (blocks[i].Groups[1].Value == "[" && blocks[i].Groups[3].Value == "]"))
                {
                    Match digits = Regex.Match(blocks[i].Groups[2].Value, @"[\d]+");

                    if (digits.Value.Length % 3 == 0)
                    {
                        for (int j = 0; j < digits.Value.Length; j+=3)
                        {
                            string currentNumber = string.Empty;

                            currentNumber += digits.Value[j];
                            currentNumber += digits.Value[j + 1];
                            currentNumber += digits.Value[j + 2];

                            int asciiValue = int.Parse(currentNumber) - blocks[i].Value.Length;

                            output += (char)asciiValue;
                        }
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}
