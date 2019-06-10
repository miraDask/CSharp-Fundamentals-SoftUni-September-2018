

namespace _06.MiddleCharacters
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            PrintMiddleCharacters(text);

        }

        public static void PrintMiddleCharacters(string text)
        {
            if (text.Length % 2 == 0)
            {
                char first = text[(text.Length / 2) - 1];
                char second = text[(text.Length / 2)];

                Console.WriteLine("" + first + second);
            }
            else
            {
                char result = text[(text.Length / 2)];
                Console.WriteLine(result);
            }
        }

    }
}
