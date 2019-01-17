using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string find = Console.ReadLine().ToLower();

            int occurences = 0;
            int index = text.IndexOf(find);

            while (index != -1)
            {
                occurences++;
                index = text.IndexOf(find, index + 1);
            }

            Console.WriteLine(occurences);
        }
    }
}
