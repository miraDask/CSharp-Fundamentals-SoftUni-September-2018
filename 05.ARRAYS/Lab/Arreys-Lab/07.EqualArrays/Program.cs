

namespace _07.EqualArrays
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfNums = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sumOfNums += firstArr[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sumOfNums}");
        }
    }
}
