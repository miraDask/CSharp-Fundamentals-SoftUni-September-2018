using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Dictionary
{
    public class Word
    {
        public Word(string name)
        {
            this.Name = name;
            this.Definitions = new List<string>();
        }
        public string Name { get; set; }

        public List<string> Definitions { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Word> words = new List<Word>();

            string firstInput = Console.ReadLine();
            string[] definitionsAndWords = firstInput.Split('|');

            foreach (var item in definitionsAndWords)
            {
                string[] wordAndDefinition = item.Split(':');

                string word = wordAndDefinition[0].Trim();
                string definition = wordAndDefinition[1].Trim();

                if (!words.Any(w => w.Name == word))
                {
                    Word currentWord = new Word(word);
                    currentWord.Definitions.Add(definition);
                    words.Add(currentWord);

                }
                else
                {
                    var currentWord = words.Find(w => w.Name == word);
                    currentWord.Definitions.Add(definition);
                }
            }

            string[] wordsToFind = Console.ReadLine().Split(" | ");

            foreach (var word in wordsToFind)
            {
                if (words.Any(w => w.Name == word))
                {
                    var currentWord = words.Find(w => w.Name == word);

                    Console.WriteLine($"{currentWord.Name}");

                    foreach (var definition in currentWord.Definitions.OrderByDescending(d => d.Length))
                    {
                        Console.WriteLine($" -{definition}");
                    }
                }

            }

            string command = Console.ReadLine();

            if (command == "End")
            {
                return;
            }
            else
            {
                var result = words.OrderBy(w => w.Name);

                string allWords = string.Empty;

                foreach (var word in result)
                {
                    allWords += word.Name + " ";
                }

                Console.WriteLine(allWords.TrimEnd());
            }
        }
    }
}
