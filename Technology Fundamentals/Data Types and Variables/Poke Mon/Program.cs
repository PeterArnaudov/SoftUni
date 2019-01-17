using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    public class Program
    {
        public static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            double halfPokePower = (pokePower / 2.0);

            int pokeCount = 0;

            while (distance <= pokePower)
            {
                pokePower -= distance;
                pokeCount++;

                if (pokePower == halfPokePower && exhaustionFactor > 0)
                    pokePower = pokePower / exhaustionFactor;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCount);
        }
    }
}
