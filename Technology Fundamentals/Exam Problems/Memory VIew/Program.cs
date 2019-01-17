using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_VIew
{
    public class Program
    {
        public static void Main()
        {
            //Programming Fundamentals Retake Exam - 25 April 2018 Part I
            string input = string.Empty;
            while (true)
            {
                string currentInput = Console.ReadLine();
                if (currentInput == "Visual Studio crash") break;
                input += currentInput + " ";
            }
            List<int> numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<string> words = new List<string>();

            int stringLength = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                string word = string.Empty;
                if (numbers[i] == 32656 && numbers[i+1] == 19759 && numbers[i+2] == 32763 && numbers[i+3] == 0)
                {
                    stringLength = numbers[i + 4];

                    for (int j = i + 6; j < i + 6 + stringLength; j++)
                    {
                        word += (char)numbers[j];
                    }

                    words.Add(word);
                    stringLength = 0;
                }

            }

            for (int i = 0; i < words.Count(); i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
