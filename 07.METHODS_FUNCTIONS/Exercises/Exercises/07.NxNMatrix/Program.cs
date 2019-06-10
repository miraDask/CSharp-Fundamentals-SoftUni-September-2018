

namespace _07.NxNMatrix
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());
            PrintMatrix(limit);

        }

        public static void PrintMatrix(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
