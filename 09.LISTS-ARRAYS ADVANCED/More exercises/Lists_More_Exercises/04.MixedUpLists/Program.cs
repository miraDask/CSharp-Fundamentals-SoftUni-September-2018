

namespace _04.MixedUpLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> firstLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var biggerLine = new List<int>();
            var smallerLine = new List<int>();

            if (firstLine.Count > secondLine.Count)
            {
                biggerLine = firstLine;
                smallerLine = secondLine;
                biggerLine.Reverse();
            }
            else if (secondLine.Count > firstLine.Count)
            {
                biggerLine = secondLine;
                smallerLine = firstLine;
            }

            
            List<int> limit = biggerLine.Take(2).ToList();
            limit.Sort();

            biggerLine = biggerLine.Skip(2).ToList();
            biggerLine.Reverse();

            var mixedLines = new List<int>();

            for (int i = 0; i < biggerLine.Count; i++)
            {
                mixedLines.Add(biggerLine[i]);
                mixedLines.Add(smallerLine[biggerLine.Count - 1 - i]);
            }           

            var resultLine = new List<int>();

            for (int i = 0; i < mixedLines.Count; i++)
            {
                if (mixedLines[i] > limit[0] && mixedLines[i] < limit[1])
                {
                    resultLine.Add(mixedLines[i]);
                }
            }

            resultLine.Sort();

            Console.WriteLine(string.Join(' ',resultLine));

        }       
    }
}
