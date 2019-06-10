namespace _06.CalculateRectangleArea
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetArea(width,height);

            Console.WriteLine(area);
        }

        private static double GetArea(double width, double height)
        {
            return width * height;
        }
    }
}
