using System;

namespace _03.ExchangeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\r\na = {firstNum}\r\nb = {secondNum}");
            Console.WriteLine($"After:\r\na = {secondNum}\r\nb = {firstNum}");
        }
    }
}
