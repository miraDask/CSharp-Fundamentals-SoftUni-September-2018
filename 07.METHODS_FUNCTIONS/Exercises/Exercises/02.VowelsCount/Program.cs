

namespace _02.VowelsCount
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            PrintVowelsCount(input);

        }

        public static void PrintVowelsCount(string text)
        {
            char[] charArrey = text.ToLower().ToCharArray();
            int count = 0;
            for (int i = 0; i < charArrey.Length; i++)
            {
                if (charArrey[i] == 'a' ||
                    charArrey[i] == 'i' ||
                    charArrey[i] == 'e' ||
                    charArrey[i] == 'o' ||
                    charArrey[i] == 'u' )
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
