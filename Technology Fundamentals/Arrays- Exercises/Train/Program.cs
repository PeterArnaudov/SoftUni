using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Program
    {
        public static void Main()
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peopleInWagons = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                peopleInWagons[i] = int.Parse(Console.ReadLine());
                sum += peopleInWagons[i];
            }

            Console.WriteLine(string.Join(" ", peopleInWagons));
            Console.WriteLine(sum);
        }
    }
}
