
namespace _03.ordSynonyms
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var wordRegister = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordRegister.ContainsKey(word))
                {
                    wordRegister.Add(word, new List<string>());

                }

                wordRegister[word].Add(synonym);
            }

            foreach (var pair in wordRegister)
            {
                Console.Write($"{pair.Key} - ");
                Console.WriteLine(string.Join(", ", pair.Value));

            }
        }
    }
}
