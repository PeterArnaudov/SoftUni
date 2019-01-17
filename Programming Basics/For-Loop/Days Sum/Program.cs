using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_Sum
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime dateTwo = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    date = date.AddDays(1);
                else if (i % 2 != 0)
                    dateTwo = dateTwo.AddDays(1);
            }

            sum = date.Day + dateTwo.Day;

            Console.WriteLine(sum);
        }
    }
}
