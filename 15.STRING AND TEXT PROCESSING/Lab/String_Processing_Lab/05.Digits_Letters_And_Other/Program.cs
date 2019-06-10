namespace _05.Digits_Letters_And_Other
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            
            string digits = string.Empty;
            string letters = string.Empty;
            string characters = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    letters += input[i];
                }
                else if (char.IsNumber(input[i]))
                {
                    digits += input[i];
                }
                else
                {
                    characters += input[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}

