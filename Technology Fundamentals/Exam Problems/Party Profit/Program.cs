using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Profit
{
    public class Program
    {
        public static void Main()
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coins = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }

                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                coins += 50;
                coins -= 2 * partySize;

                bool motivationalDay = false;
                bool bossDay = false;

                if (i % 3 == 0)
                {
                    motivationalDay = true;
                }

                if (i % 5 == 0)
                {
                    bossDay = true;
                }

                if (motivationalDay && bossDay)
                {
                    coins += partySize * 20;
                    coins -= 5 * partySize;
                }
                else if (motivationalDay)
                {
                    coins -= 3 * partySize;
                }
                else if (bossDay)
                {
                    coins += partySize * 20;
                }
            }

            Console.WriteLine($"{partySize} companions received {coins / partySize} coins each.");
        }
    }
}
