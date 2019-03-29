namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
    {
        public static void Main()
        {
            Console.Write("Enter the desired directory: ");
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> extensions = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directory = new DirectoryInfo(input);

            FileInfo[] files = directory.GetFiles();

            foreach (var file in files)
            {
                if (!extensions.ContainsKey(file.Extension))
                {
                    extensions.Add(file.Extension, new Dictionary<string, double>());
                }

                extensions[file.Extension].Add(file.Name, file.Length);
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string outputFile = Path.Combine(desktopPath, "report.txt");

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (var extension in extensions.OrderByDescending(x => x.Value.Keys.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(extension.Key);

                    foreach (var file in extension.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value/1000}kb");
                    }
                }
            }
        }
    }
}
