using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    public class Program
    {
        public static void Main()
        {
            string remove = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();

            while (input.Contains(remove))
            {
                int index = input.IndexOf(remove);
                input = input.Remove(index, remove.Length);
            }

            Console.WriteLine(input);
        }
    }
}
