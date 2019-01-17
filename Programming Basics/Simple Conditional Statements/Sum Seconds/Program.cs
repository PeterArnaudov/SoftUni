using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main()
        {
            int contester1 = int.Parse(Console.ReadLine());
            int contester2 = int.Parse(Console.ReadLine());
            int contester3 = int.Parse(Console.ReadLine());

            int totalSeconds = contester1 + contester2 + contester3;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            if (seconds < 10)
                Console.WriteLine($"{minutes}:0{seconds}");
            else if (seconds >= 10)
                Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}
