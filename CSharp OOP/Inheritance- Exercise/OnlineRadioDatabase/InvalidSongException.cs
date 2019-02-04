namespace OnlineRadioDatabase
{
    using System;

    public class InvalidSongException : Exception
    {
        private const string Message = "Invalid song.";

        public InvalidSongException()
            :base(Message)
        {
        }

        public InvalidSongException(string message)
            :base(message)
        {
        }
    }
}
