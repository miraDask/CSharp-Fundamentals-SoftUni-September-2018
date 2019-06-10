namespace _03.Substring
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            while (text.Contains(word))
            {
                text = text.Replace(word, string.Empty);
            }


            Console.WriteLine(text);
        }
    }
}
