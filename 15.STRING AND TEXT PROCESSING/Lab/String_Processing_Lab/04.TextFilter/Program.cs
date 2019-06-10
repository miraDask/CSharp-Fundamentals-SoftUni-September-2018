namespace _04.TextFilters
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string replacement = new string('*', bannedWords[i].Length);
                text = text.Replace(bannedWords[i], replacement);

            }

            Console.WriteLine(text);
        }

    }
}
