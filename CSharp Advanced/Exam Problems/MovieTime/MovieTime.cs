namespace MovieTime
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class MovieTime
    {
        public static void Main()
        {
            string desiredGenre = Console.ReadLine();
            string length = Console.ReadLine();
            TimeSpan totalTime = new TimeSpan(0, 0, 0);

            Dictionary<string, Dictionary<string, TimeSpan>> genres = new Dictionary<string, Dictionary<string, TimeSpan>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "POPCORN!")
                {
                    break;
                }

                string[] info = input.Split('|');

                string movieName = info[0];
                string movieGenre = info[1];
                int[] movieTime = info[2].Split(':').Select(int.Parse).ToArray();

                TimeSpan movieLength = new TimeSpan(movieTime[0], movieTime[1], movieTime[2]);
                totalTime += movieLength;

                if (!genres.ContainsKey(movieGenre))
                {
                    genres.Add(movieGenre, new Dictionary<string, TimeSpan>());
                }

                genres[movieGenre].Add(movieName, movieLength);
            }

            if (length == "Short")
            {
                foreach (var movie in genres[desiredGenre].OrderBy(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine(movie.Key);

                    string opinion = Console.ReadLine();

                    if (opinion == "Yes")
                    {
                        Console.WriteLine($"We're watching {movie.Key} - {movie.Value}");
                        break;
                    }
                }
            }
            else if (length == "Long")
            {
                foreach (var movie in genres[desiredGenre].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine(movie.Key);

                    string opinion = Console.ReadLine();

                    if (opinion == "Yes")
                    {
                        Console.WriteLine($"We're watching {movie.Key} - {movie.Value}");
                        break;
                    }
                }
            }

            Console.WriteLine($"Total Playlist Duration: {totalTime}");
        }
    }
}
