using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder shiftedText = new StringBuilder();

            foreach (var character in text)
            {
                char shiftedChar = character;

                shiftedChar += (char)3;

                shiftedText.Append(shiftedChar);
            }

            Console.WriteLine(shiftedText);
        }
    }
}
