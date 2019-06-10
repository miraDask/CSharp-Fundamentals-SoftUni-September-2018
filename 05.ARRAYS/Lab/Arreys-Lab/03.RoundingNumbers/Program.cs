﻿

namespace _03.RoundingNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double roundedNum = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundedNum}");
            }
        }
    }
}
