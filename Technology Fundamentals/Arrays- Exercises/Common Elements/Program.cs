using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Elements
{
    public class Program
    {
        public static void Main()
        {
            string[] arrayOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrayTwo = Console.ReadLine().Split(' ').ToArray();
            string output = string.Empty;

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                for (int j = 0; j < arrayOne.Length; j++)
                {
                    if (arrayTwo[i] == arrayOne[j])
                        output += $"{arrayTwo[i]} ";
                }
            }

            Console.WriteLine(output);
        }
    }
}
