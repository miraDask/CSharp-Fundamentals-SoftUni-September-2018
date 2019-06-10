using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();



            int[] bestSeq = FindLongestIncreasingSubsequence(sequence);

            Console.WriteLine(string.Join(" ",bestSeq));

        }

        public static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            int[] length = new int[sequence.Length];
            int[] previous = new int[sequence.Length];
            int maxLen = 0;
            int maxIndex = -1;

            for (int x = 0; x < sequence.Length; x++)
            {
                length[x] = 1;
                previous[x] = -1;

                for (int i = 0; i < x; i++)
                {
                    if (sequence[x] > sequence[i] && length[x] <= length[i])
                    {
                        length[x] = length[i] + 1;
                        previous[x] = i;

                    }
                }

                if (length[x] > maxLen)
                {
                    maxLen = length[x];
                    maxIndex = x;
                }
            }

            var longestSeq = new List<int>();


                while (maxIndex != -1)
                {
                    longestSeq.Add(sequence[maxIndex]);
                    maxIndex = previous[maxIndex];
                }
            

            longestSeq.Reverse();

            return longestSeq.ToArray();

        }
    }
}
