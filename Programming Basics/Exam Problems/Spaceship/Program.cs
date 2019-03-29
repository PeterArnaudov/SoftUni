using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Program
    {
        static void Main()
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double astronautHeight = double.Parse(Console.ReadLine());

            double shipVolume = shipWidth * shipLength * shipHeight;
            double spacePerAstronaut = 2 * 2 * (astronautHeight + 0.4);
            double astronauts = Math.Floor(shipVolume / spacePerAstronaut);
            string exit = string.Empty;

            if (astronauts >= 3 && astronauts <= 10)
                exit = $"The spacecraft holds {astronauts} astronauts.";
            else if (astronauts < 3)
                exit = $"The spacecraft is too small.";
            else if (astronauts > 10)
                exit = $"The spacecraft is too big.";

            Console.WriteLine(exit);
        }
    }
}
