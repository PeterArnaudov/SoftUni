using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int pairOne = 0;
            int pairTwo = 0;
            int difference = 0;
            int maxdifference = 0;

            for (int i = 0; i < n; i++)
            {
                int numberOne = int.Parse(Console.ReadLine());
                int numberTwo = int.Parse(Console.ReadLine());
                pairOne = numberOne + numberTwo;

                if (i != 0)
                    if (pairOne != pairTwo)
                    {
                        difference = Math.Abs(pairOne - pairTwo);
                        if (difference > maxdifference)
                            maxdifference = difference;
                    }
                pairTwo = pairOne;
            }
            if (maxdifference == 0)
                Console.WriteLine("Yes, value={0}", pairTwo);
            else
                Console.WriteLine("No, maxdiff={0}", maxdifference);
        }
    }
}
