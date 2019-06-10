using System;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Over!")
                {
                    break;
                }

                int number = int.Parse(Console.ReadLine());

                Regex regex = new Regex($@"^([0-9]+)([a-zA-Z]{{{number}}})([^A-Za-z]*)$");

                Match match = regex.Match(line);

                if (match.Success)
                {
                    string text = match.Groups[2].ToString();

                    char[] firstPart = match.Groups[1].ToString().ToCharArray();
                    char[] secondPart = match.Groups[3].ToString().ToCharArray();

                    string decryptedMessage = string.Empty;

                    foreach (var character in firstPart)
                    {
                        decryptedMessage += GetCharacter(character, text);
                    }

                    foreach (var character in secondPart)
                    {
                        if (char.IsDigit(character))
                        {
                            decryptedMessage += GetCharacter(character, text);
                        }

                    }

                    Console.WriteLine($"{text} == {decryptedMessage}");

                }
            }
        }

        private static char GetCharacter(char character, string text)
        {
            char neededChar = ' ';

            int index = int.Parse(character.ToString());

            if (index >= 0 && index <= text.Length - 1)
            {
                neededChar = text[index];
            }

            return neededChar;
        }
    }
}
