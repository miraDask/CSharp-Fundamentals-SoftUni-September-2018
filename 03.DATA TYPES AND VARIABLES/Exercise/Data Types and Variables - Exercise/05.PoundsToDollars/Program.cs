using System;

namespace _05.PoundsToDollars
{
    public class Program
    {
        public static void Main()
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * 1.31m;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
