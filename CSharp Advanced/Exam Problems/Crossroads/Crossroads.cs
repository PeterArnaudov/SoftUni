namespace Crossroads
{
    using System;
    using System.Collections.Generic;

    public class Crossroads
    {
        public static void Main()
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int passed = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else if (input == "green" && cars.Count > 0)
                {
                    int seconds = greenDuration;
                    Queue<char> currentCar = new Queue<char>(cars.Peek());

                    while (cars.Count != 0)
                    {
                        if (currentCar.Count == 0)
                        {
                            cars.Dequeue();
                            passed++;

                            if (cars.Count > 0 && seconds > 0)
                            {
                                currentCar = new Queue<char>(cars.Peek());
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (seconds == 0)
                        {
                            break;
                        }

                        seconds--;
                        currentCar.Dequeue();
                    }

                    if (currentCar.Count > 0)
                    {
                        seconds += freeWindow;

                        while (currentCar.Count != 0 && seconds != 0)
                        {
                            seconds--;
                            currentCar.Dequeue();
                        }

                        if (currentCar.Count > 0)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{cars.Peek()} was hit at {currentCar.Peek()}.");
                            return;
                        }

                        cars.Dequeue();
                        passed++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passed} total cars passed the crossroads.");
        }
    }
}
