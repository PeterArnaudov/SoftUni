using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Filter
{
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();

            foreach (var word in words.Where(x => x.Length % 2 == 0))
            {
                Console.WriteLine(word);
            }

            //solution two:
            //string[] words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //solution three:
            //Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
