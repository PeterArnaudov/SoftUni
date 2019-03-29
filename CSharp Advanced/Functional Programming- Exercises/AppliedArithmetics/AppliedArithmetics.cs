namespace AppliedArithmetics
{
    using System;
    using System.Linq;

    public class AppliedArithmetics
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Action<int[]> printer = x => Console.WriteLine(string.Join(" ", x));

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = ForEach(numbers, x => ++x);
                }
                else if (command == "subtract")
                {
                    numbers = ForEach(numbers, x => --x);
                }
                else if (command == "multiply")
                {
                    numbers = ForEach(numbers, x => x * 2);
                }
                else if (command == "print")
                {
                    printer(numbers);
                }

                command = Console.ReadLine();
            }
        }

        public static int[] ForEach(int[] numbers, Func<int, int> func)
        {
            return numbers.Select(x => func(x)).ToArray();
        }
    }
}
