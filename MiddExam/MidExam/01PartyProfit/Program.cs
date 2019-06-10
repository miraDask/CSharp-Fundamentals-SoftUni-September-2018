using System;

namespace _01PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 0;

            for (int i = 1; i <= days; i++)
            {
                coins += 50;

                if (i % 10 == 0 && i != 1)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0 && i != 1)
                {
                    partySize += 5;
                }

                
                coins -= 2 * partySize;

                if (i % 3 == 0 && i % 5 == 0 && i != 1)
                {
                    coins += 20 * partySize;
                    coins -= 5 * partySize;
                }
                else if (i % 3  == 0)
                {
                    coins -= 3 * partySize;
                }
                else if (i % 5 == 0 && i != 1)
                {
                    coins += 20 * partySize;
                }
                
            }

            Console.WriteLine($"{partySize} companions received {coins/partySize} coins each.");
        }
    }
}
