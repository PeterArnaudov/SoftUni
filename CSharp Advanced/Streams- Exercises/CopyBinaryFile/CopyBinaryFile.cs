namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        public static void Main()
        {
            string path = "../../../";
            string fileName = "copyMe.png";
            string sourcePath = Path.Combine(path, fileName);

            var source = new FileStream(sourcePath, FileMode.Open);

            using (source)
            {
                string destinationPath = Path.Combine(path, "copied.png");

                var destination = new FileStream(destinationPath, FileMode.Create);

                using (destination)
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];

                        int readBytes = source.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
