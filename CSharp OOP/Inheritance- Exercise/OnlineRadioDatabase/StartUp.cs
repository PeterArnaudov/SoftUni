namespace OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songInfo = Console.ReadLine().Split(';');

                try
                {
                    Song song = new Song(songInfo[0], songInfo[1], songInfo[2]);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine(GetPlaylistLength(songs));            
        }

        public static string GetPlaylistLength(List<Song> playlist)
        {
            int totalSeconds = playlist.Select(s => s.SongSeconds).Sum();
            int secondsToMinutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            int totalMinutes = playlist.Select(s => s.SongMinutes).Sum() + secondsToMinutes;
            int minutesToHours = totalMinutes / 60;
            int minutes = totalMinutes % 60;

            int hours = minutesToHours;

            return $"Playlist length: {hours}h {minutes}m {seconds}s";
        }
    }
}
