using System;

namespace _04.PrintAndSum
{
    public class Program
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int finalNum = int.Parse(Console.ReadLine());

            int sumOfNums = 0;

            for (int i = startNum; i <= finalNum; i++)
            {
                Console.Write(i + " ");
                sumOfNums += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sumOfNums}");
        }
    }
}
