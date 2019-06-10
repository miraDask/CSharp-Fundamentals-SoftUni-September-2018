

namespace _03.BakingFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] bestBatch = new int[10];
            int bestQuality = int.MinValue;
            int bestLength = int.MinValue;
            double bestAvarageQuality = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Bake It!")
                {
                    break;
                }

                int[] currentBatchOfBread = input.Split("#").Select(int.Parse).ToArray();

                int currentQuality = GetQuality(currentBatchOfBread);
                int currentLength = currentBatchOfBread.Length;
                double currentAverageQuality = currentQuality /(double)currentBatchOfBread.Length;

                if (currentQuality > bestQuality)
                {
                    bestQuality = currentQuality;
                    bestBatch = currentBatchOfBread;
                    bestLength = currentLength;
                    bestAvarageQuality = currentAverageQuality;


                }
                else
                {

                    if (currentQuality == bestQuality && currentAverageQuality > bestAvarageQuality)
                    {
                        bestAvarageQuality = currentAverageQuality;
                        bestQuality = currentQuality;
                        bestBatch = currentBatchOfBread;
                        bestLength = currentLength;
                    }
                    else if (currentAverageQuality == bestAvarageQuality && currentLength < bestLength)
                    {
                        bestQuality = currentQuality;
                        bestBatch = currentBatchOfBread;
                        bestLength = currentLength;
                        bestAvarageQuality = currentAverageQuality;
                    }
                }
            }

            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(' ', bestBatch));
        }

        private static int GetQuality(int[] currentBatchOfBread)
        {
            int quality = 0;

            for (int i = 0; i < currentBatchOfBread.Length; i++)
            {
                quality += currentBatchOfBread[i];
            }

            return quality;
        }
    }
}
