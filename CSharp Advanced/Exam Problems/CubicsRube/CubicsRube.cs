namespace CubicsRube
{
    using System;
    using System.Linq;

    public class CubicsRube
    {
        public static void Main()
        {
            int sizes = int.Parse(Console.ReadLine());

            int[,,] matrix = new int[sizes, sizes, sizes];

            long sum = 0;
            int notChanged = sizes * sizes * sizes;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Analyze")
                {
                    break;
                }

                int[] info = input.Split().Select(int.Parse).ToArray();
                int dimensionOne = info[0];
                int dimensionTwo = info[1];
                int dimensionThree = info[2];
                int value = info[3];

                if (dimensionOne >= 0 && dimensionOne < sizes &&
                    dimensionTwo >= 0 && dimensionTwo < sizes &&
                    dimensionThree >= 0 && dimensionThree < sizes &&
                    value != 0)
                {
                    notChanged--;
                    sum += value;
                }
            }

            Console.WriteLine(sum);
            Console.WriteLine(notChanged);
        }
    }
}
