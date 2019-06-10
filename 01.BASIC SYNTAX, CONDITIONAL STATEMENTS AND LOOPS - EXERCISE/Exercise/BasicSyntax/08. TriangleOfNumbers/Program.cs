using System;

namespace _08._TriangleOfNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write(row + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
