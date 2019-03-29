using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int count = 0;

            for (int numberOne = 0; numberOne <= number; numberOne++)
            {
                for (int numberTwo = 0; numberTwo <= number; numberTwo++)
                {
                    for (int numberThree = 0; numberThree <= number; numberThree++)
                    {
                        for (int numberFour = 0; numberFour <= number; numberFour++)
                        {
                            for (int numberFive = 0; numberFive <= number; numberFive++)
                            {
                                if ((numberOne + numberTwo + numberThree + numberFour + numberFive) == number)
                                    count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
