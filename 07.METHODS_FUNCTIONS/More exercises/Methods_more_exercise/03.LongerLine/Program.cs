
namespace _03.LongerLine
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
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = GetLengthOfLine(x1,y1,x2,y2);
            double secondLineLength = GetLengthOfLine(x3,y3,x4,y4);

            if (firstLineLength >= secondLineLength)
            {
                double firstPointDistanceToCentre = GetDistanceToCentre(x1, y1);
                double secondPointdistanceToCentre = GetDistanceToCentre(x2, y2);

                if (firstPointDistanceToCentre <= secondPointdistanceToCentre)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else if(secondPointdistanceToCentre < firstPointDistanceToCentre)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (secondLineLength > firstLineLength)
            {
                double firstPointDistanceToCentre = GetDistanceToCentre(x3, y3);
                double secondPointdistanceToCentre = GetDistanceToCentre(x4, y4);

                if (firstPointDistanceToCentre <= secondPointdistanceToCentre)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else if (secondPointdistanceToCentre < firstPointDistanceToCentre)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static double GetDistanceToCentre(double x, double y)
        {
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return result;
        }

        private static double GetLengthOfLine(double x1, double y1, double x2, double y2)
        {
            double result = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));

            return result;
        }
    }
}
