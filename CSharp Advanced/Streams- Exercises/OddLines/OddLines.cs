namespace Odd_Lines
{
    using System;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            string path = "../../../";
            string fileName = "text.txt";

            path = Path.Combine(path, fileName);

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                bool odd = false;

                while (line != null)
                {
                    if (odd)
                    {
                        Console.WriteLine(line);
                    }

                    odd = !odd;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
