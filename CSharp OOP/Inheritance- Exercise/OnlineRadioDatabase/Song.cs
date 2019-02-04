namespace OnlineRadioDatabase
{
    using OnlineRadioDatabase.InvalidSongExceptions;
    using OnlineRadioDatabase.InvalidSongLengthExceptions;
    using System;

    public class Song
    {
        private const int ArtistNameMinLength = 3;
        private const int ArtistNameMaxLength = 20;
        private const int SongNameMinLength = 3;
        private const int SongNameMaxLength = 30;
        private const int MinSongMinutes = 0;
        private const int MaxSongMinutes = 14;
        private const int MinSongSeconds = 0;
        private const int MaxSongSeconds = 59;

        private string artistName;
        private string songName;
        private int songMinutes;
        private int songSeconds;
        private string songLength;

        public Song(string artistName, string songName, string length)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SongLength = length;
        }

        private string ArtistName
        {
            get => this.artistName;

            set
            {
                if (value.Length < ArtistNameMinLength || value.Length > ArtistNameMaxLength)
                {
                    throw new InvalidArtistNameException(ArtistNameMinLength, ArtistNameMaxLength);
                }

                this.artistName = value;
            }
        }

        private string SongName
        {
            get => this.songName;

            set
            {
                if (value.Length < SongNameMinLength || value.Length > SongNameMaxLength)
                {
                    throw new InvalidSongNameException(SongNameMinLength, SongNameMaxLength);
                }

                this.songName = value;
            }
        }

        public int SongMinutes
        {
            get => this.songMinutes;

            private set
            {
                if (value < MinSongMinutes || value > MaxSongMinutes)
                {
                    throw new InvalidSongMinutesException(MinSongMinutes, MaxSongMinutes);
                }

                this.songMinutes = value;
            }
        }

        public int SongSeconds
        {
            get => this.songSeconds;

            private set
            {
                if (value < MinSongSeconds || value > MaxSongSeconds)
                {
                    throw new InvalidSongSecondsException(MinSongSeconds, MaxSongSeconds);
                }

                this.songSeconds = value;
            }
        }

        private string SongLength
        {
            get => this.songLength;

            set
            {
                string[] tokens = value.Split(':');

                int minutes;
                int seconds;
                bool isNumeric = int.TryParse(tokens[0], out minutes) && int.TryParse(tokens[1], out seconds);

                if (tokens.Length != 2 || !isNumeric)
                {
                    throw new InvalidSongLengthException();
                }

                this.SongMinutes = int.Parse(tokens[0]);
                this.SongSeconds = int.Parse(tokens[1]);
            }
        }
    }
}
