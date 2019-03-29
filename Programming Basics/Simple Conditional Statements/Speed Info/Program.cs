using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Info
{
    class Program
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            string speedInfo;

            if (speed <= 10)
                speedInfo = "slow";
            else if (speed > 10 && speed <= 50)
                speedInfo = "average";
            else if (speed > 50 && speed <= 150)
                speedInfo = "fast";
            else if (speed > 150 && speed <= 1000)
                speedInfo = "ultra fast";
            else
                speedInfo = "extremely fast";

            Console.WriteLine(speedInfo);
        }
    }
}
