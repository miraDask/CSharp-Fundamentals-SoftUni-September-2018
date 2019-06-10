namespace _04.MorseCodeTranslator
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string decodedText = string.Empty;

            Dictionary<char, string> morseCode = new Dictionary<char, string>()
            {
                {'A', ".-"},
                {'B', "-..." },
                {'C', "-.-." },
                {'D', "-.." },
                {'E', "." },
                {'F', "..-." },
                {'G', "--." },
                {'H', "...." },
                {'I', ".." },
                {'J', ".---" },
                {'K', "-.-" },
                {'L', ".-.." },
                {'M', "--" },
                {'N', "-." },
                {'O', "---" },
                {'P', ".--." },
                {'Q', "--.-" },
                {'R', ".-." },
                {'S', "..." },
                {'T', "-" },
                {'U', "..-" },
                {'V', "...-" },
                {'W', ".--" },
                {'X', "-..-" },
                {'Y', "-.--" },
                {'Z', "--.." },
            };

            string[] morseText = Console.ReadLine().Split();

            for (int i = 0; i < morseText.Length; i++)
            {
                string currentCode = morseText[i];

                if (currentCode == "|")
                {
                    decodedText += currentCode;
                }
                else
                {
                    foreach (var pair in morseCode)
                    {
                        if (pair.Value == currentCode)
                        {
                            decodedText += pair.Key;
                        }
                    }
                }
            }

            decodedText = decodedText.Replace("|", " ");
            Console.WriteLine(decodedText);
        }
    }
}
