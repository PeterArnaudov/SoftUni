using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Integers
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string output = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool topInteger = false;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                        topInteger = true;
                    else
                    {
                        topInteger = false;
                        break;
                    }
                }
                if (topInteger)
                    output += $"{numbers[i]} ";
                if (i == numbers.Length - 1)
                    output += $"{numbers[i]}";
            }

            Console.WriteLine(output);
        }
    }
}
