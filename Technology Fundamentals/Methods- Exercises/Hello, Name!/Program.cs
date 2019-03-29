using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__Name_
{
    public class Program
    {
        public static void Main()
        {
            string greeting = PrintGreeting(Console.ReadLine());
            Console.WriteLine(greeting);
        }

        public static string PrintGreeting(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
