namespace OnlineRadioDatabase.InvalidSongExceptions
{
    using System;

    public class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException()
            :base()
        {
        }

        public InvalidSongNameException(string message) 
            :base(message)
        {
        }

        public InvalidSongNameException(int min, int max)
            :base($"Song name should be between {min} and {max} symbols.")
        {
        }
    }
}
