namespace Deciphering
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string encrypted = Console.ReadLine();
            string[] key = Console.ReadLine().Split();

            Match valid = Regex.Match(encrypted, @"[^d-z{},|#]");

            if (valid.Value.Length > 0)
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            string halfDecrypted = string.Empty;

            for (int i = 0; i < encrypted.Length; i++)
            {
                char current = (char)((encrypted[i]) - 3);

                halfDecrypted += current;
            }

            string decrypted = Regex.Replace(halfDecrypted, $"{key[0]}", $"{key[1]}");

            Console.WriteLine(decrypted);
        }
    }
}
