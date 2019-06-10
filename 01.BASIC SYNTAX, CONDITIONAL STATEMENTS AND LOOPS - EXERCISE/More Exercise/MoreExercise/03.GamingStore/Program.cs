using System;

namespace _03.GamingStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;
            string game = Console.ReadLine();

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    
                    default:
                        
                        break;
                }

                if (price == 0)
                {
                    Console.WriteLine("Not Found");
                }
                else if (price <= budget)
                {
                    budget -= price;
                    total += price;
                    Console.WriteLine($"Bought {game}");
                }
                else
                {
                    Console.WriteLine($"Too Expensive");
                }

                if (budget <= 0)
                {
                    Console.WriteLine($"Out of money!");
                    return;
                }
                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${total:F2}. Remaining: ${budget:F2}");
        }
    }
}
