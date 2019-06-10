namespace _01.SignOfIntegerNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintNumberSign(number);
        }

        private static void PrintNumberSign(int number)
        {
            string sign = string.Empty;

            if (number < 0)
            {
                sign = "negative";
            }
            else if (number > 0)
            {
                sign = "positive";
            }
            else
            {
                sign = "zero";
            }

            Console.WriteLine($"The number {number} is {sign}.");
        }
    }
}
