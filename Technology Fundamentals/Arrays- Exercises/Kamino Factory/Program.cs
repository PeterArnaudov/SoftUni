using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamino_Factory
{
    public class Program
    {
        public static void Main()
        {
            int samplesLength = int.Parse(Console.ReadLine());
            string sample = Console.ReadLine();

            List<int[]> samples = new List<int[]>();

            while (sample != "Clone them!")
            {
                int[] currentSample = sample.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (currentSample.Length == samplesLength)
                {
                    samples.Add(currentSample);
                }

                sample = Console.ReadLine();
            }

            int index = 1;
            int bestStartIndex = samplesLength;
            int bestLength = 0;
            int bestSum = 0;
            string bestSample = string.Join(" ", samples[0]);

            for (int sampleIndex = 0; sampleIndex < samples.Count; sampleIndex++)
            {
                int sum = samples[sampleIndex].Sum();
                int startIndex = samplesLength;
                int currentBestLength = 0;
                int currentLength = 0;

                for (int i = 0; i < samples[sampleIndex].Length; i++)
                {
                    if (samples[sampleIndex][i] == 1)
                    {
                        currentLength++;
                    }
                    else
                    {
                        if (currentLength > currentBestLength)
                        {
                            currentBestLength = currentLength;
                            startIndex = i - currentLength;
                        }

                        currentLength = 0;
                    }
                }

                if (currentBestLength > bestLength)
                {
                    bestLength = currentBestLength;
                    index = sampleIndex + 1;
                    bestSum = sum;
                    bestStartIndex = startIndex;
                    bestSample = string.Join(" ", samples[sampleIndex]);
                }
                else if (currentBestLength == bestLength)
                {
                    if (bestStartIndex > startIndex)
                    {
                        index = sampleIndex + 1;
                        bestSum = sum;
                        bestStartIndex = startIndex;
                        bestSample = string.Join(" ", samples[sampleIndex]);
                    }
                    else if (bestStartIndex == startIndex)
                    {
                        if (bestSum < sum)
                        {
                            index = sampleIndex + 1;
                            bestSum = sum;
                            bestSample = string.Join(" ", samples[sampleIndex]);
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {index} with sum: {bestSum}.");
            Console.WriteLine($"{bestSample}");
        }
    }
}