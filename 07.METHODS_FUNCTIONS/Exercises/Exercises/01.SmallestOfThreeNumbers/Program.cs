

namespace _01.SmallestOfThreeNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            PrintSmallestNum(firstNum, secondNum, thirdNum);

        }

        public static void PrintSmallestNum(int first, int second, int third)
        {
            if (first <= second && first <= third)
            {
                Console.WriteLine(first);
            }
            else if (second <= first && second <= third)
            {
                Console.WriteLine(second);
            }
            else if (third <= first && third <= second)
            {
                Console.WriteLine(third);

            }
        }
    }
}
