using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    public class Program
    {
        public static void Main()
        {
            string[] banned = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in banned)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
