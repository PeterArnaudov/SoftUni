namespace Traffic_Light
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int carsPass = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int carsPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "green")
                {
                    for (int i = 0; i < carsPass; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }

                        Console.WriteLine($"{cars.Dequeue()} passed!");

                        carsPassed++;
                    }
                }
                else if (input == "end")
                {
                    Console.WriteLine($"{carsPassed} cars passed the crossroads.");

                    return;
                }
                else
                {
                    cars.Enqueue(input);
                }
            }
        }
    }
}
