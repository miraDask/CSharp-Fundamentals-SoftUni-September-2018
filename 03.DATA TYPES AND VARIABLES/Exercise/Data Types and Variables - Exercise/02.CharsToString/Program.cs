using System;

namespace _02.CharsToString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char firstChar =char.Parse(Console.ReadLine());
            char secondChar =char.Parse(Console.ReadLine());
            char thirdChar =char.Parse(Console.ReadLine());

            string result = firstChar.ToString() + secondChar.ToString() + thirdChar.ToString();
            Console.WriteLine(result);
        }
    }
}
