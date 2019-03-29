namespace Logger.Files
{
    using System;
    using System.IO;
    using System.Linq;

    public class LogFile : IFile
    {
        private string path = "../../../log.txt";

        public LogFile()
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);
            fileStream.Close();
        }

        public int Size
        {
            get
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    return reader.ReadToEnd().ToCharArray().Where(char.IsLetter).Sum(c => c);
                }
            }
        }

        public void Write(string content)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(content);
            }
        }
    }
}
