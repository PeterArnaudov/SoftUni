namespace OnlineRadioDatabase.InvalidSongLengthExceptions
{
    using OnlineRadioDatabase.InvalidSongExceptions;
    using System;

    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException()
            : base()
        {
        }

        public InvalidSongMinutesException(string message)
            :base(message)
        {
        }

        public InvalidSongMinutesException(int min, int max)
            :base($"Song minutes should be between {min} and {max}.")
        {
        }
    }
}
