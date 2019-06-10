using System;

namespace _07._VendingMachine
{
    public class Program
    {
        public static void Main()
        {
            decimal sum = 0;
            decimal nutsPrice = 2.0m;
            decimal waterPrice = 0.7m;
            decimal crispsPrice = 1.5m;
            decimal sodaPrice = 0.8m;
            decimal cokePrice = 1.0m;

            while (true)
            {
                string input = Console.ReadLine();
                decimal currentCoin;
                bool isMoney = decimal.TryParse(input, out currentCoin);

                if (isMoney)
                {

                    if (currentCoin == 0.1m || currentCoin == 0.2m || currentCoin == 0.5m || currentCoin == 1.0m || currentCoin == 2.0m)
                    {
                        sum += currentCoin;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {currentCoin}");
                    }

                }
                else
                {
                    if (input == "Start")
                    {

                    }

                    else if (input == "Nuts")
                    {
                        if (nutsPrice <= sum)

                        {
                            Console.WriteLine("Purchased nuts");
                            sum -= nutsPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (input == "Coke")
                    {
                        if (cokePrice <= sum)
                        {
                            Console.WriteLine("Purchased coke");
                            sum -= cokePrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (input == "Water")
                    {
                        if (waterPrice <= sum)
                        {
                            Console.WriteLine("Purchased water");
                            sum -= waterPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (input == "Crisps")
                    {
                        if (crispsPrice <= sum)
                        {
                            Console.WriteLine("Purchased crisps");
                            sum -= crispsPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (input == "Soda")
                    {
                        if (sodaPrice <= sum)
                        {
                            Console.WriteLine("Purchased soda");
                            sum -= sodaPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (input == "End")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }


                }
            }

            Console.WriteLine($"Change: {sum:f2}");


        }
    }
}
