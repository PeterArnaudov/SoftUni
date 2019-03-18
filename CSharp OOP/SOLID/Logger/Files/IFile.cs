namespace Logger.Files
{
    using System;

    public interface IFile
    {
        int Size { get; }

        void Write(string content);
    }
}
