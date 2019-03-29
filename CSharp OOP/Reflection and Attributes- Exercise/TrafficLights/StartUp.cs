namespace TrafficLights
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            List<TrafficLight> trafficLights = new List<TrafficLight>();

            foreach (var token in input)
            {
                trafficLights.Add((TrafficLight)Activator.CreateInstance(typeof(TrafficLight), token));
            }

            int cycles = int.Parse(Console.ReadLine());

            for (int i = 0; i < cycles; i++)
            {
                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.Change();
                    Console.Write(typeof(TrafficLight).GetField("signal", BindingFlags.NonPublic | BindingFlags.Instance)
                        .GetValue(trafficLight) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
