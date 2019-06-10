using System;
using System.Collections.Generic;

namespace _01.BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bit = int.Parse(Console.ReadLine());

            string binaryValueOfNum = GetValue(number);

            int count = 0;

            for (int i = 0; i < binaryValueOfNum.Length; i++)
            {
                if (binaryValueOfNum[i] - '0' == bit)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        private static string GetValue(int number)
        {
            List<string> binaryValue = new List<string>();

            while (number > 0)
            {
                binaryValue.Add((number % 2).ToString());
                number /= 2;
            }

            binaryValue.Reverse();

            return string.Join("", binaryValue);
        }
    }
}
