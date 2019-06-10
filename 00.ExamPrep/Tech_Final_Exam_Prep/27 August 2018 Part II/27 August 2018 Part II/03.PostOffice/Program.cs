namespace _03.PostOffice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('|');

            Regex upperCaseMatch = new Regex(@"([#\$%\*&])(?<letters>[A-Z]+)\1");
            Regex codeAndWordLength = new Regex(@"(?<code>[6-9][0-9]):(?<length>[0-9]{2}(?!\.))");

            Match lettersMatch = upperCaseMatch.Match(input[0]);
            List<char> letters = new List<char>();

            if (lettersMatch.Success)
            {
                letters = lettersMatch.Groups["letters"].Value.ToList();
            }

            MatchCollection codeAndWordLengthMatches = codeAndWordLength.Matches(input[1]);
            string[] words = input[2].Split(new[] { ' ', '\t' });

            List<string> selectedWords = new List<string>();

            for (int i = 0; i < letters.Count; i++)
            {
                foreach (Match match in codeAndWordLengthMatches)
                {
                    char startLetter = ' ';
                    int length = 0;

                    startLetter = (char)int.Parse(match.Groups["code"].Value);
                    length = int.Parse(match.Groups["length"].Value) + 1;

                    if (letters[i] == startLetter)
                    {

                        foreach (var word in words)
                        {
                            if (word[0] == startLetter && word.Length == length)
                            {
                                if (!selectedWords.Contains(word))
                                {
                                    selectedWords.Add(word);
                                    break;
                                }
                            }
                        }

                    }

                }
            }


            Console.WriteLine(string.Join(Environment.NewLine, selectedWords));

        }
    }
}
