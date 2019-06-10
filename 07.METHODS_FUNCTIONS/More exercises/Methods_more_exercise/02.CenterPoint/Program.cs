
namespace _02.CenterPoint
{
    using System;

    public class Program
    {
        public static void Main()
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPointDistance = GetPointDistanceTo0(x1, y1);
            double secondPointDistance = GetPointDistanceTo0(x2, y2);

            if (firstPointDistance <= secondPointDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double GetPointDistanceTo0(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x,2)+ Math.Pow(y,2));

            return result;
        }
    }
}
