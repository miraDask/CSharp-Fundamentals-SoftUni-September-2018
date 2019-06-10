
namespace _02.RepeatStrings
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();

            string result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    result += words[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
