using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<string> inputList = (input.Split('|').ToList());

            for (int i = inputList.Count() - 1; i >= 0; i--)
                inputList[i].Split(' ').ToList();

            inputList.Reverse();

            //foreach (string item in inputList)
            //{
            //    Console.Write(item.Trim() + ' ');
            //}

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
