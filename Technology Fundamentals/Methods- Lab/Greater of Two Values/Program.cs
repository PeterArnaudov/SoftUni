using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    public class Program
    {
        public static void Main()
        {
            string valueType = Console.ReadLine();
            if (valueType == "int")
            {
                int greater = GetMaxInt(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                Console.WriteLine(greater);
            }
            else if (valueType == "char")
            {
                char greater = GetMaxChar(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
                Console.WriteLine(greater);
            }
            else if (valueType == "string")
            {
                string greater = GetMaxString(Console.ReadLine(), Console.ReadLine());
                Console.WriteLine(greater);
            }
        }

        public static int GetMaxInt(int first, int second)
        {
            return (Math.Max(first, second));
        }

        public static char GetMaxChar(char first, char second)
        {
            if (first > second)
                return (first);
            else
                return (second);
        }

        public static string GetMaxString(string first, string second)
        {
            if (first.CompareTo(second) > 0)
                return (first);
            else
                return (second);
        }
    }
}
