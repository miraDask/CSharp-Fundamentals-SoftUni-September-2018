using System;

namespace _02.CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * radius * radius;

            Console.WriteLine($"{circleArea:F12}");
        }
    }
}
