using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * lenght * height;
            int totalBoxes = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done" || volume <= totalBoxes) break;
                else
                {
                    int boxes = int.Parse(command);
                    totalBoxes += boxes;
                }
            }

            if (volume >= totalBoxes)
                Console.WriteLine($"{volume - totalBoxes} Cubic meters left.");
            else
                Console.WriteLine($"No more free space! You need {totalBoxes - volume} Cubic meters more.");
        }
    }
}
