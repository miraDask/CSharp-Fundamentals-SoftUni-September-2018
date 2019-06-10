namespace _02.CharacterMultiplier
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];

            int totalSum = GetTotalSum(firstWord, secondWord);

            Console.WriteLine(totalSum);
        }

        private static int GetTotalSum(string firstWord, string secondWord)
        {
            string longerWord = string.Empty;
            string shorterWord = string.Empty;

            if (firstWord.Length >= secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else if (secondWord.Length > firstWord.Length)
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }

            int totalSum = 0;

            for (int i = 0; i < longerWord.Length; i++)
            {
                if (i + 1 > shorterWord.Length)
                {
                    totalSum += (int)longerWord[i];
                }
                else
                {
                    totalSum += (int)longerWord[i] * (int)shorterWord[i];
                }
            }

            return totalSum;
        }
    }
}
