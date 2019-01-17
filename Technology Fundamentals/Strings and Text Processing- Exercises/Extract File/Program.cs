using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extract_File
{
    public class Program
    {
        public static void Main()
        {
            string path = Console.ReadLine();

            string pattern = @".+:\\.+\\.+\\(.+)\.(.+)";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(path);

            Console.WriteLine($"File name: {match.Groups[1].Value}");
            Console.WriteLine($"File extension: {match.Groups[2].Value}");
        }
    }
}
