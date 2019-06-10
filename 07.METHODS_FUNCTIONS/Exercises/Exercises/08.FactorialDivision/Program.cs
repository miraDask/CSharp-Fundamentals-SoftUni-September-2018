

namespace _08.FactorialDivision
{
    using System;
    

    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = (double)Factorial(firstNumber) /Factorial(secondNumber);
            Console.WriteLine($"{result:F2}");
        }

        public static long Factorial(int number)
        {
            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
