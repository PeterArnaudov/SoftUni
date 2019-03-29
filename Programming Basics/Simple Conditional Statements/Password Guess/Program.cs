using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Guess
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            bool correctPassword = password == "s3cr3t!P@ssw0rd";

            if (correctPassword)
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Wrong password!");
        }
    }
}
