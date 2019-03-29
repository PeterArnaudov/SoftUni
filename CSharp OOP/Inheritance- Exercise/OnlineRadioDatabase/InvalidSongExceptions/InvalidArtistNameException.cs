namespace OnlineRadioDatabase.InvalidSongExceptions
{
    using System;

    public class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException()
            :base()
        {
        }

        public InvalidArtistNameException(string message)
            :base(message)
        {
        }

        public InvalidArtistNameException(int min, int max)
            :base($"Artist name should be between {min} and {max} symbols.")
        {
        }
    }
}
