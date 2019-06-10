namespace _09.MultiplyEvensByOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string numSequence = Console.ReadLine();

            string pattern = @"\d";

            MatchCollection matches = Regex.Matches(numSequence, pattern);

            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            foreach (Match match in matches)
            {
                int number = int.Parse(match.Value);

                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }

            int sumOfOddNums = GetSumOfOddDigits(oddNumbers);
            int sumOfEvenNums = GetSumOfEvenDigits(evenNumbers);

            int resultOfMultiplicaation = GetMultipleOfEvenAndOdds(sumOfEvenNums, sumOfOddNums);

            Console.WriteLine(resultOfMultiplicaation);
        }

        private static int GetMultipleOfEvenAndOdds(int sumOfEvenNums, int sumOfOddNums)
        {
            return sumOfOddNums * sumOfEvenNums;
        }

        private static int GetSumOfEvenDigits(List<int> evenNumbers)
        {
            int sum = 0;

            foreach (var item in evenNumbers)
            {
                sum += item;
            }
            return sum;
        }

        private static int GetSumOfOddDigits(List<int> oddNumbers)
        {
            int sum = 0;

            foreach (var item in oddNumbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}
