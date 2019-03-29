using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string exit = string.Empty;

            if (gender == "m")
            {
                if (age >= 16)
                    exit = "Mr.";
                else
                    exit = "Master";
            }
            else if (gender == "f")
            {
                if (age >= 16)
                    exit = "Ms.";
                else
                    exit = "Miss";
            }

            Console.WriteLine(exit);
        }
    }
}
