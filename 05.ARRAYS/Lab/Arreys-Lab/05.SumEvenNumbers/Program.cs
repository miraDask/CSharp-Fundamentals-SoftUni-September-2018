

namespace _05.SumEvenNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfEvenNums = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvenNums += numbers[i];
                }
            }
            Console.WriteLine(sumOfEvenNums);
        }
    }
}
