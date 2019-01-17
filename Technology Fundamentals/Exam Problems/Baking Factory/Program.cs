using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baking_Factory
{
    public class Program
    {
        public static void Main()
        {
            string bread = Console.ReadLine();

            List<int[]> allBreads = new List<int[]>();
            List<int[]> bestQualityBreads = new List<int[]>();
            List<int[]> bestAvgBreads = new List<int[]>();
            List<int[]> bestLengthBreads = new List<int[]>();

            while (bread != "Bake It!")
            {
                int[] currentBread = bread.Split("#".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                allBreads.Add(currentBread);

                bread = Console.ReadLine();
            }

            int bestLength = int.MaxValue;
            int bestSum = int.MinValue;
            double bestAvg = int.MinValue;

            for (int breadIndex = 0; breadIndex < allBreads.Count; breadIndex++)
            {
                int sum = allBreads[breadIndex].Sum();

                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
            for (int breadIndex = 0; breadIndex < allBreads.Count; breadIndex++)
            {
                int sum = allBreads[breadIndex].Sum();

                if (sum == bestSum)
                {
                    bestQualityBreads.Add(allBreads[breadIndex]);
                }
            }

            if (bestQualityBreads.Count >= 2)
            {

                for (int breadIndex = 0; breadIndex < allBreads.Count; breadIndex++)
                {
                    double avg = allBreads[breadIndex].Average();

                    if (avg > bestAvg)
                    {
                        bestAvg = avg;
                    }
                }
                for (int breadIndex = 0; breadIndex < allBreads.Count; breadIndex++)
                {
                    double avg = allBreads[breadIndex].Average();

                    if (avg == bestAvg)
                    {
                        bestAvgBreads.Add(bestQualityBreads[breadIndex]);
                    }
                }
            }

            if (bestAvgBreads.Count >= 2)
            {

                for (int breadIndex = 0; breadIndex < bestAvgBreads.Count; breadIndex++)
                {
                    int length = bestAvgBreads[breadIndex].Length;

                    if (length < bestLength)
                    {
                        bestLength = length;
                    }
                }

                for (int breadIndex = 0; breadIndex < bestAvgBreads.Count; breadIndex++)
                {
                    int length = bestAvgBreads[breadIndex].Length;

                    if (length == bestLength)
                    {
                        bestLengthBreads.Add(bestAvgBreads[breadIndex]);
                    }
                }
            }

            if (bestLengthBreads.Count == 1)
            {
                Console.WriteLine($"Best Batch quality: {bestSum}");
                Console.WriteLine(string.Join(" ", bestLengthBreads[0]));
            }
            else if (bestAvgBreads.Count == 1)
            {
                Console.WriteLine($"Best Batch quality: {bestSum}");
                Console.WriteLine(string.Join(" ", bestAvgBreads[0]));
            }
            else
            {
                Console.WriteLine($"Best Batch quality: {bestSum}");
                Console.WriteLine(string.Join(" ", bestQualityBreads[0]));
            }

        }
    }
}