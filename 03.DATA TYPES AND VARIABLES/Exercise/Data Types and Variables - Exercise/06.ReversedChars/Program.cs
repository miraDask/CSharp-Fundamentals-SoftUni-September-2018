using System;

namespace _06.ReversedChars
{
    public class Program
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            string result = thirdChar.ToString()+ " " +secondChar.ToString()+ " " + firstChar.ToString();
            Console.WriteLine(result);
        }
    }
}
