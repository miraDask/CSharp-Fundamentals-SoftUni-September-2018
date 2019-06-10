namespace _02.AsciiSumator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char finalSymbol = char.Parse(Console.ReadLine());
            string token = Console.ReadLine();
            int totalSum = 0;
            for (int i = 0; i < token.Length; i++)
            {
                char currentSymbol = token[i];

                if ((int)currentSymbol > firstSymbol && (int)currentSymbol < finalSymbol)
                {
                   totalSum += (int)currentSymbol;
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
