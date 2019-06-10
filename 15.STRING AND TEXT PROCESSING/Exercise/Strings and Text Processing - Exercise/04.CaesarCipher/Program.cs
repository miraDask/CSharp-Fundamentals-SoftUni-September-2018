namespace _04.CaesarCipher
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                char newChar = (char)((int)currentChar + 3);

                sb.Append(newChar);
            }
            string encriptedInput = sb.ToString();
            Console.WriteLine(encriptedInput);
        }
    }
}
