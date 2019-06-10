using System;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            if (n == 1 || n == 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                numbers[0] = 1;
                numbers[1] = 1;
                for (int i = 2; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }
                Console.WriteLine(numbers[n - 1]);
            }



        }
    }
}
