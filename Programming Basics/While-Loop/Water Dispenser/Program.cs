using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Dispenser
{
    class Program
    {
        static void Main()
        {
            int glassVolume = int.Parse(Console.ReadLine());
            int millmillilitersPerPress = 0;
            int presses = 0;
            int filled = 0;
            string button = string.Empty;

            while (true)
            {
                if (glassVolume == filled)
                {
                    Console.WriteLine("The dispenser has been tapped {0} times.", presses);
                    break;
                }
                else if (glassVolume < filled)
                {
                    Console.WriteLine("{0}ml has been spilled.", filled - glassVolume);
                    break;
                }

                button = Console.ReadLine();

                if (button == "Easy")
                    millmillilitersPerPress = 50;
                else if (button == "Medium")
                    millmillilitersPerPress = 100;
                else if (button == "Hard")
                    millmillilitersPerPress = 200;

                filled = filled + millmillilitersPerPress;
                presses++;
            }
        }
    }
}
