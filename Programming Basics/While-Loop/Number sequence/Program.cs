using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_sequence
{
    class Program
    {
        static void Main()
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            while (true)
            {
                string end = Console.ReadLine();

                if (end == "END")
                    break;

                int number = int.Parse(end);

                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max number: {0}", max);
            Console.WriteLine("Min number: {0}", min);
        }
    }
}
