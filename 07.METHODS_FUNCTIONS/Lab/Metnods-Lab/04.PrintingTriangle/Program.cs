namespace _04.PrintingTriangle
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintingTriangle(number);
        }

        private static void PrintingTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            int end = number - 1;
            
            for (int row = number - 1; row >= 1; row--)
            {

                for (int i = 1; i <= end; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                end--;
            }
        }
    }
}
