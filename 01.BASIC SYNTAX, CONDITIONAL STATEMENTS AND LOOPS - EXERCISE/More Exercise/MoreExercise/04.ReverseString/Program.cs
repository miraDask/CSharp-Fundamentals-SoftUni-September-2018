using System;

namespace _04.ReverseString
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            
            string reverced = String.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverced += input[i];
            }

            Console.WriteLine(reverced);
        }
    }
}
