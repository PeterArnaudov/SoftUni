namespace Song_Encryption
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"^([A-Z][a-z' ]+):([A-Z ]+)$";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string artist = match.Groups[1].Value;
                string song = match.Groups[2].Value;

                int upper = 0;
                for (int i = 0; i < artist.Length; i++)
                {
                    if (char.IsUpper(artist[i]))
                    {
                        upper++;
                    }
                }

                if (upper > 1)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int key = artist.Length;

                string encryptedArtist = string.Empty;
                string encryptedSong = string.Empty;

                for (int i = 0; i < artist.Length; i++)
                {
                    char current = artist[i];

                    if (current != 32 && current != 39)
                    {
                        for (int j = 0; j < key; j++)
                        {
                            current++;
                            if (current == '{')
                            {
                                current = 'a';
                            }
                            else if (current == '[')
                            {
                                current = 'A';
                            }
                        }
                    }

                    encryptedArtist += current;
                }

                for (int i = 0; i < song.Length; i++)
                {
                    char current = song[i];

                    if (current != 32)
                    {
                        for (int j = 0; j < key; j++)
                        {
                            current++;
                            if (current == '{')
                            {
                                current = 'a';
                            }
                            else if (current == '[')
                            {
                                current = 'A';
                            }
                        }
                    }

                    encryptedSong += current;
                }

                Console.WriteLine($"Successful encryption: {encryptedArtist}@{encryptedSong}");
            }
        }
    }
}
