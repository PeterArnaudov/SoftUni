using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Change_Numbers
{
    public class Program
    {
        public static void Main()
        {
            char[] separators = { ' ', '\t' };
            string[] strings = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0.0;

            for (int i = 0; i < strings.Length; i++)
            {
                char firstLetter = strings[i][0];
                char secondLetter = strings[i][strings[i].Length - 1];

                strings[i] = strings[i].Remove(0, 1);
                strings[i] = strings[i].Remove(strings[i].Length - 1, 1);

                double number = double.Parse(strings[i]);

                if (char.IsUpper(firstLetter))
                {
                    int divide = firstLetter - 64;
                    number /= divide;
                }
                else
                {
                    int multiply = firstLetter - 96;
                    number *= multiply;
                }

                if (char.IsUpper(secondLetter))
                {
                    int substract = secondLetter - 64;
                    number -= substract;
                }
                else
                {
                    int add = secondLetter - 96;
                    number += add;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
