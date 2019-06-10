using System;

namespace _10.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

           
            for (int i = 1; i <= number; i++)
            {
                int sumOfDigits = 0;
                bool isSpecial = false;
                int currentNum = i;

                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    isSpecial = true;
                } 

                Console.WriteLine($"{i} -> {isSpecial}");
                
            }

        }
    }
}
