using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_Strings
{
    public class Program
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine().Split();
            //string output = string.Empty;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings[i].Length; j++)
                {
                    //output = string.Concat(output, strings[i]);
                    result.Append(strings[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
