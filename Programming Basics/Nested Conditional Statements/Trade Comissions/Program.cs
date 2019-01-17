using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main()
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            bool sofia = city == "Sofia";
            bool varna = city == "Varna";
            bool plovdiv = city == "Plovdiv";

            double percent = 1;

            if (sales >= 0 && sales <= 500)
            {
                if (sofia)
                    percent = 0.05;
                else if (varna)
                    percent = 0.045;
                else if (plovdiv)
                    percent = 0.055;
            }
            else if (sales > 500 && sales <= 1000)
            {
                if (sofia)
                    percent = 0.07;
                else if (varna)
                    percent = 0.075;
                else if (plovdiv)
                    percent = 0.08;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                if (sofia)
                    percent = 0.08;
                else if (varna)
                    percent = 0.1;
                else if (plovdiv)
                    percent = 0.12;
            }
            else if (sales > 10000)
            {
                if (sofia)
                    percent = 0.12;
                else if (varna)
                    percent = 0.13;
                else if (plovdiv)
                    percent = 0.145;
            }

            double comission = sales * percent;
            Console.WriteLine($"{comission:f2}");

            if (city != "Sofia" || city != "Varna" || city != "Plovdiv" || sales < 0)
                Console.WriteLine("error");
        }
    }
}
