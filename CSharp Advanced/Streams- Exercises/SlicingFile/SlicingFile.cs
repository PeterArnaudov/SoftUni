namespace SlicingFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class SlicingFile
    {
        public static void Main()
        {
            Console.Write("Choose command: ");
            string command = Console.ReadLine().ToLower();

            while (true)
            {
                if (command == "slice")
                {
                    Console.Write("Enter the count of parts: ");
                    int parts = int.Parse(Console.ReadLine());

                    Console.Write("Enter name of chosen the file (with its extension): ");
                    string fileName = Console.ReadLine();

                    string path = "../../../";
                    path = Path.Combine(path, fileName);

                    Slice(path, string.Empty, parts);
                    break;
                }
                else if (command == "assemble")
                {
                    Console.Write("Choose how to enter the files: "); //folder or files

                    List<string> files = new List<string>();

                    string inputType = Console.ReadLine().ToLower();

                    if (inputType == "files")
                    {
                        Console.WriteLine("Enter the names of your files, each on a new line. Leave empty line if you want to preceed.");

                        string input = " ";
                        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
                        {
                            files.Add(input);
                        }
                    }
                    else if (inputType == "folder")
                    {
                        Console.Write("Enter the directory of the folder: ");
                        string input = Console.ReadLine();

                        //add functionality
                    }
                    else
                    {
                        Console.WriteLine("Invalid command! Choose between folder and files!");
                        Console.Write("Choose how to enter the files: ");
                        inputType = Console.ReadLine().ToLower();
                    }

                    Assemble(files, string.Empty);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Choose between slice and assemble!");
                    Console.Write("Choose command: ");
                    command = Console.ReadLine().ToLower();
                }
            }
        }

        public static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                string extension = Path.GetExtension(sourceFile);
                Int64 partSize = source.Length / parts + 1;

                for (int i = 0; i < parts; i++)
                {
                    destinationDirectory = $"Part-{i}{extension}";

                    using (var destination = new FileStream(destinationDirectory, FileMode.CreateNew))
                    {
                        byte[] buffer = new byte[4096];

                        while (destination.Length < partSize)
                        {
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

        public static void Assemble(List<string> files, string destinationDirectory)
        {
            if (files.Count == 0)
            {
                return;
            }

            string extension = Path.GetExtension(files[0]);
            destinationDirectory = $"assembled{extension}";

            using (var assembled = new FileStream(destinationDirectory, FileMode.Append))
            {
                foreach (var file in files)
                {
                    try
                    {
                        string path = Path.Combine("../../../", file);

                        using (var currentFile = new FileStream(path, FileMode.Open))
                        {
                            byte[] buffer = new byte[4096];

                            int readBytes = currentFile.Read(buffer, 0, buffer.Length);

                            while (readBytes != 0)
                            {
                                assembled.Write(buffer, 0, readBytes);
                                readBytes = currentFile.Read(buffer, 0, buffer.Length);
                            }
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine($"File {file} cannot be found! The Assemble will be completed without this file.");
                    }
                }
            }
        }
    }
}
