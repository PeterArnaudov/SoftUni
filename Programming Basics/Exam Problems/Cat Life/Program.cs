using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Life
{
    class Program
    {
        static void Main()
        {
            // Programming Basics Online Exam - 16 and 17 June 2018
            // 14:15 - 14:27 <12 min>
            // 100/100

            string breed = Console.ReadLine();
            string gender = Console.ReadLine();

            bool male = gender == "m";
            bool female = gender == "f";
            bool british = breed == "British Shorthair";
            bool siamese = breed == "Siamese";
            bool persian = breed == "Persian";
            bool ragdoll = breed == "Ragdoll";
            bool american = breed == "American Shorthair";
            bool siberian = breed == "Siberian";

            int years = 0;

            if (male)
            {
                if (british)
                    years = 13;
                else if (siamese)
                    years = 15;
                else if (persian)
                    years = 14;
                else if (ragdoll)
                    years = 16;
                else if (american)
                    years = 12;
                else if (siberian)
                    years = 11;
                else
                {
                    Console.WriteLine($"{breed} is invalid cat!");
                    return;
                }
            }
            else if (female)
            {
                if (british)
                    years = 14;
                else if (siamese)
                    years = 16;
                else if (persian)
                    years = 15;
                else if (ragdoll)
                    years = 17;
                else if (american)
                    years = 13;
                else if (siberian)
                    years = 12;
                else
                {
                    Console.WriteLine($"{breed} is invalid cat!");
                    return;
                }
            }

            int humanMonths = years * 12;
            int catMonths = humanMonths / 6;

            Console.WriteLine($"{catMonths} cat months");
        }
    }
}
