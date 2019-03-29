namespace DependencyInversion
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            PrimitiveCalculator calculator = new PrimitiveCalculator();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }
                else if (input[0] == "mode")
                {
                    calculator.ChangeStrategy(input[1][0]);
                }
                else
                {
                    Console.WriteLine(calculator.PerformCalculation(int.Parse(input[0]), int.Parse(input[1])));
                }
            }
        }
    }
}
