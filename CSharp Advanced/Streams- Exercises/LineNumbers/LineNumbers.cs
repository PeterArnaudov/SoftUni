namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            string path = "../../../";
            string fileName = "text.txt";
            path = Path.Combine(path, fileName);

            string outputFileName = "output.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(outputFileName))
                {
                    string line = reader.ReadLine();
                    int counter = 0;

                    while (line != null)
                    {
                        line = $"Line {++counter}:{line}";

                        writer.WriteLine(line);

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
