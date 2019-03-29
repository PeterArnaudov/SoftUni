using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            //int courseCounter = 0;

            //while (true)
            //{
            //    courseCounter++;
            //    numberOfPeople -= elevatorCapacity;

            //    if (numberOfPeople <= 0)
            //    {
            //        Console.WriteLine(courseCounter);
            //        return;
            //    }
            //}

            if (numberOfPeople % elevatorCapacity == 0)
                Console.WriteLine(numberOfPeople / elevatorCapacity);
            else
                Console.WriteLine((numberOfPeople / elevatorCapacity) + 1);
        }
    }
}
