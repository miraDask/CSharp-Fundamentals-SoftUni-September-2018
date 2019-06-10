

namespace _01.DataTypes
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int number = int.Parse(Console.ReadLine());

                PrintResult(number);
            }
            else if (input == "real")
            {
                double floatingNum = double.Parse(Console.ReadLine());
                PrintResult(floatingNum);
            }
            else if (input == "string")
            {
                string text = Console.ReadLine();
                PrintResult(text);
            }

        }

        private static void PrintResult(string text)
        {
            Console.WriteLine($"${text}$");
        }

        private static void PrintResult(double floatingNum)
        {
            Console.WriteLine($"{(floatingNum * 1.5):f2}");
        }

        public static void PrintResult(int number)
        {
            Console.WriteLine(number * 2);
        }
    }
}
