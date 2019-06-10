namespace _05.Orders
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintTotalPrice(product, quantity);
        }

        private static void PrintTotalPrice(string product, int quantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1.0;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2.0;
                    break;
            }

            double totalPrice = price * quantity;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
