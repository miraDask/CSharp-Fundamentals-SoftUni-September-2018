using System;

namespace _07._VendingMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            decimal sum = 0;
            

            while (input != "Start")
            {


                switch (input)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        sum += decimal.Parse(input);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {input}");
                        break;
                }

                input = Console.ReadLine();

            }


            input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                decimal productPrice = 0;
                switch (input)
                {
                    case "nuts":
                        productPrice = 2.0m;
                        break;
                    case "coke":
                        productPrice = 1.0m;
                        break;
                    case "water":
                        productPrice = 0.7m;
                        break;
                    case "crisps":
                        productPrice = 1.5m;
                        break;
                    case "soda":
                        productPrice = 0.8m;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (productPrice <= sum && productPrice > 0 && sum > 0)
                {
                    Console.WriteLine($"Purchased {input}");
                    sum -= productPrice;
                }
                else if (productPrice > sum)
                {
                    Console.WriteLine("Sorry, not enough money");
                }


                input = Console.ReadLine().ToLower();



            }

            Console.WriteLine($"Change: {sum:f2}");


        }
    }
}
