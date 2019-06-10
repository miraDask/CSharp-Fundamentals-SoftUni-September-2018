using System;

namespace _06._StrongNumber
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int tempNum = number;
            int digitFactorialSum = 0;

            while (tempNum != 0)
            {
                int currentDigit = 0;
                int factorial = 1;
                currentDigit = tempNum % 10;
                tempNum = tempNum / 10;

                while (currentDigit >= 1)
                {
                    factorial *= currentDigit;
                    currentDigit--;
                }

                digitFactorialSum += factorial;
            }

            if (digitFactorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
