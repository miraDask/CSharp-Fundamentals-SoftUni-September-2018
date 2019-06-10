namespace _03.Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex bojomonRegex = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");
            Regex didimonRegex = new Regex(@"[^a-zA-Z\-]+");

            int count = 1;

            for (int i = 0; i < input.Length; i++)
            {
                Match didiMatch = didimonRegex.Match(input);
                Match bojoMatch = bojomonRegex.Match(input);
                Match match = didiMatch;
                if (count % 2 == 0)
                {
                    match = bojoMatch;
                }
                else
                {
                    match = didiMatch;
                }

                if (!match.Success)
                {
                    return;
                }

                string result = match.ToString();

                Console.WriteLine(match);

                int lengthToCut = GetLength(input, result);
                input = input.Remove(0, lengthToCut);

                i--;
                count++;
            }
        }

        private static int GetLength(string input, string result)
        {
            int index = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == result[0])
                {
                    index = i + result.Length;
                    break;
                }
            }

            return index;
        }
    }
}
