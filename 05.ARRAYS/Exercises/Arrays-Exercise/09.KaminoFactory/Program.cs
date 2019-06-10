
namespace _09.KaminoFactory
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

                int[] currentSample = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentSum = 0;
                int currentIndex = -1;


                for (int i = 0; i < currentSample.Length; i++)
                {
                    currentSum += currentSample[i];
                }
                int currentSequenceLength = 1;


                for (int i = 0; i < currentSample.Length; i++)
                {

                    if (currentSample[i] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        for (int j = i + 1; j < currentSample.Length; j++)
                        {
                            if (currentSample[j] == 0)
                            {
                                break;
                            }
                            else
                            {
                                currentSequenceLength++;


                                if (currentSequenceLength == 2)
                                {
                                    currentIndex = i;
                                }

                            }
                        }

                    }


                }
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
                            bestDNASample = currentSample;
                            sum = currentSum;
                            sampleNum = currentCount;
                        }
                    }
                }

                currentCount++;

            }
            Console.WriteLine($"Best DNA sample {sampleNum} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", bestDNASample));

        }
    }
}

