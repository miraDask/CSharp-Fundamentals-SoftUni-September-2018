

namespace _02.PrintNumbersInReverseOrder
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());
            int[] numbers = new int[limit];

            for (int i = 0; i < limit; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
