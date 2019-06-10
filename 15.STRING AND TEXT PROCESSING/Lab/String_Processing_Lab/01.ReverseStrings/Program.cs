
namespace _01.ReverseStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, char[]> words = new Dictionary<string, char[]>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                char[] reversed = input.Reverse().ToArray();
                words[input] = reversed;

            }

            foreach (var pair in words)
            {
                Console.WriteLine($"{pair.Key} = {string.Join(string.Empty,pair.Value)}");
            }
        }
    }
}
