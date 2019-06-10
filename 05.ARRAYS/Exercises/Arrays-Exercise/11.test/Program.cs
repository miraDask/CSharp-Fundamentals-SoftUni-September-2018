

namespace _11.KaminoFactory2
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int DNALength = int.Parse(Console.ReadLine());

            int[] bestDNASample = new int[DNALength];

            int longestSequenceLength = 0;

            int firstIndex = -1;
            int sum = 0;
            int sampleNum = 0;
            int currentCount = 1;

            while (true)
            {
                string input = Console.ReadLine();


                if (input == "Clone them!")
                {
                    break;
                }

                int[] currentSample = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentSum = 0;




                for (int i = 0; i < currentSample.Length; i++)
                {
                    currentSum += currentSample[i];
                }

                if (currentCount == 1)
                {
                    bestDNASample = currentSample;
                    sampleNum = currentCount;
                    sum = currentSum;
                }

                int currentSequenceLength = 0;
                int currentIndex = -1;

                for (int i = 0; i < currentSample.Length; i++)
                {

                    if (currentSample[i] == 1)
                    {

                        if (currentSequenceLength == 1)
                        {
                            currentIndex = i;
                        }

                        currentSequenceLength++;

                        if (currentSequenceLength > longestSequenceLength)
                        {
                            longestSequenceLength = currentSequenceLength;
                            bestDNASample = currentSample;
                            sum = currentSum;
                            sampleNum = currentCount;
                            firstIndex = currentIndex;

                        }
                        else if (currentSequenceLength == longestSequenceLength)
                        {
                            if (currentIndex < firstIndex)
                            {
                                longestSequenceLength = currentSequenceLength;
                                bestDNASample = currentSample;
                                sum = currentSum;
                                sampleNum = currentCount;
                                firstIndex = currentIndex;
                            }
                            else
                            {
                                if (currentSum > sum)
                                {
                                    longestSequenceLength = currentSequenceLength;
                                    bestDNASample = currentSample;
                                    sum = currentSum;
                                    sampleNum = currentCount;
                                    firstIndex = currentIndex;
                                }
                            }
                        }


                    }
                    else
                    {
                        currentIndex = -1;
                        currentSequenceLength = 0;

                    }


                }

                currentCount++;
            }

            Console.WriteLine($"Best DNA sample {sampleNum} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", bestDNASample));
        }
    }
}

