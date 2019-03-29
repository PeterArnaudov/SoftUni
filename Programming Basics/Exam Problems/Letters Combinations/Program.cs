using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Program
    {
        static void Main()
        {
            // Programming Basics Exam - 18 December 2016
            // 15:34 - 15:40 <6 min>
            // 100/100

            char start = char.Parse(Console.ReadLine());
            char final = char.Parse(Console.ReadLine());
            char omit = char.Parse(Console.ReadLine());

            int count = 0;

            for (char letterOne = start; letterOne <= final; letterOne++)
            {
                for (char letterTwo = start; letterTwo <= final; letterTwo++)
                {
                    for (char letterThree = start; letterThree <= final; letterThree++)
                    {
                        if (letterOne != omit && letterTwo != omit && letterThree != omit)
                        {
                            Console.Write($"{letterOne}{letterTwo}{letterThree} ");
                            count++;
                        }
                    }
                }
            }

            Console.Write(count);
        }
    }
}
