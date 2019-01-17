using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogswatch
{
    public class Program
    {
        public static void Main()
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int initialPresents = int.Parse(Console.ReadLine());

            int presents = initialPresents;
            List<int> kidsInEachHome = new List<int>();

            for (int i = 0; i < homesToVisit; i++)
            {
                int childrenPerHouse = int.Parse(Console.ReadLine());
                kidsInEachHome.Add(childrenPerHouse);
            }

            int comebacks = 0;
            int homesVisited = 0;
            int remainingHomes = kidsInEachHome.Count;
            int presentsLeft = 0;
            int additionalPresents = 0;

            while (kidsInEachHome.Count > 0 || remainingHomes > 0)
            {
                for (int i = 0; i < kidsInEachHome.Count; i++)
                {
                    while (kidsInEachHome[i] > 0 && presents > 0)
                    {
                        kidsInEachHome[i]--;
                        presents--;
                    }

                    homesVisited = i + 1;
                    remainingHomes = kidsInEachHome.Count - homesVisited;
                    presentsLeft = kidsInEachHome[i];

                    if (presents == 0)
                    {
                        break;
                    }
                }

                kidsInEachHome.RemoveAll(x => x == 0);

                if (kidsInEachHome.Count == 0)
                {
                    break;
                }

                comebacks++;
                presents = (initialPresents / homesVisited) * remainingHomes + presentsLeft;
                additionalPresents += presents;
            }

            if (comebacks == 0)
            {
                Console.WriteLine(presents);
            }
            else
            {
                Console.WriteLine(comebacks);
                Console.WriteLine(additionalPresents);
            }
        }
    }
}