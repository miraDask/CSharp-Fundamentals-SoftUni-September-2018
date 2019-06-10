

namespace _06.EqualSum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int countLeft = 0; countLeft < i; countLeft++)
                {
                    leftSum += numbers[countLeft];
                }

                for (int countRight = i + 1; countRight < numbers.Length; countRight++)
                {
                    rightSum += numbers[countRight];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }

            Console.WriteLine("no");

        }
    }
}
