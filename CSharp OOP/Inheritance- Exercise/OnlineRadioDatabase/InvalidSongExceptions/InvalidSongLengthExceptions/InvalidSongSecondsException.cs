namespace OnlineRadioDatabase.InvalidSongLengthExceptions
{
    using System;
    using InvalidSongExceptions;

    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException()
            :base()
        {
        }

        public InvalidSongSecondsException(string message)
            :base(message)
        {
        }

        public InvalidSongSecondsException(int min, int max)
            :base($"Song seconds should be between {min} and {max}.")
        {
        }
    }
}
