using System;

namespace _12.Even_Number
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    if (number < 0)
                    {
                        Console.WriteLine($"The number is: {Math.Abs(number)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The number is: {number}");
                        break;
                    }

                }
            }
        }
    }
}
