using System;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < input; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                sum += currentNum;
            }

            Console.WriteLine(sum);
        }
    }
}
