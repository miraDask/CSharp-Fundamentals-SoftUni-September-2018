namespace _07.MathPower
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int power)
        {
            return  Math.Pow(number, power);

        }
    }
}
