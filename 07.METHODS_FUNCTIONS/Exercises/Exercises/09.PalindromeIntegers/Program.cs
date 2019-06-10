

namespace _09.PalindromeIntegers
{
    using System;

    public class Program
    {
        public static void Main()
        {


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(IsPalindrome(input, ReverceString(input))? "true" : "false");               
                }
            }
        }

        public static string ReverceString(string text)
        {
            string revercedText = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                revercedText += text[i];
            }

            return revercedText;
        }

        public static bool IsPalindrome(string text, string reverecedText)
        {
            return text == reverecedText ? true : false;
        }
    }
}
