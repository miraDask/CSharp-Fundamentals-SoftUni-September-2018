

namespace _01.CountCharsInAString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
           List<char> input = Console.ReadLine()
                .Where(ch => ch != ' ')
                .ToList();

            var charCountInfo = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!charCountInfo.ContainsKey(character))
                {
                    charCountInfo[character] = 0;
                }

                charCountInfo[character]++;
            }

            foreach (var kvp in charCountInfo)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
