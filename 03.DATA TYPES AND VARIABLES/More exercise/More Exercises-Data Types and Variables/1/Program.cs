using System;

namespace _04.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            bool isEqual = true;

            if (Math.Abs(firstNum - secondNum) >= eps)
            {
                isEqual = false;
            }

            Console.WriteLine(isEqual);
        }
    }
}
