

namespace _06.EvenAndOddSubtraction
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfOddNums = 0;
            int sumOfEvenNums = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvenNums += numbers[i];
                }
                else
                {
                    sumOfOddNums += numbers[i];
                }
            }

            int diff = sumOfEvenNums - sumOfOddNums;

            Console.WriteLine(diff);
            
        }
    }
}
