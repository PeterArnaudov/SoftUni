using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Explosion
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            int explosionPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (explosionPower > 0 && input[i] != '>')
                {
                    explosionPower--;
                    continue;
                }
                else if (explosionPower > 0 && input[i] == '>')
                {
                    result += input[i];
                    explosionPower += (int)Char.GetNumericValue(input[i + 1]);
                }
                else if (input[i] != '>')
                {
                    result += input[i];
                }
                else if (input[i] == '>')
                {
                    result += input[i];
                    explosionPower += (int)Char.GetNumericValue(input[i + 1]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
