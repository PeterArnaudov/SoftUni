using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    public class Program
    {
        public static void Main()
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '"', (char)39, '\\', '/', '!', '?', ' ' };
            List<string> input = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            input = input.Distinct().Where(word => word.Length < 5).ToList();

            input.Sort();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
