using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> register = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }

                Regex namePattern = new Regex(@"[A-Za-z]");
                Regex numberPattern = new Regex(@"[0-9]");
                // Regex symbolsToRemove = new Regex(@"[\W_]");
                int sum = 0;
                string name = string.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    bool HasLetterMatch = namePattern.Match(input[i].ToString()).Success;
                    bool HasNumberMatch = numberPattern.Match(input[i].ToString()).Success;

                    if (HasNumberMatch)
                    {
                        sum += int.Parse(input[i].ToString());

                    }
                    else if (HasLetterMatch)
                    {
                        name += input[i];
                    }
                    else
                    {
                        continue;
                    }
                }

                if (names.Contains(name))
                {
                    if (!register.ContainsKey(name))
                    {
                        register[name] = sum;
                    }
                    else
                    {
                        register[name] += sum;
                    }
                }
            }

            var orderedReg = register.OrderByDescending(x => x.Value);

            int count = 1;
            List<string> winners = new List<string>();

            foreach (var pair in orderedReg)
            {
                winners.Add(pair.Key);

                if (count == 3)
                {
                    break;
                }
                count++;
            }

            string resultText = $"1st place: {winners[0]}{Environment.NewLine}2nd place: {winners[1]}{Environment.NewLine}3rd place: {winners[2]}";

            Console.WriteLine(resultText);
        }
    }
}
