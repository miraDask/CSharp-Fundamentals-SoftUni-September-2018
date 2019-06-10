namespace _04.SoftUniCoffeeSupplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, long> coffeeQuantityReg = new Dictionary<string, long>();
            Dictionary<string, string> clientsReg = new Dictionary<string, string>();


            string delimeters = Console.ReadLine();
            string[] keys = delimeters.Split();
            string firstDelimiter = keys[0];
            string secondDelimiter = keys[1];

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of info")
                {
                    break;
                }

                if (input.Contains(firstDelimiter))
                {
                    string[] data = input.Split(new string[] { firstDelimiter }, StringSplitOptions.RemoveEmptyEntries);
                    string personName = data[0];
                    string coffeeType = data[1];

                    if (!clientsReg.ContainsKey(personName))
                    {
                        if (!clientsReg.Any(x => x.Value == coffeeType))
                        {
                            coffeeQuantityReg[coffeeType] = 0;
                        }

                        clientsReg[personName] = coffeeType;
                    }



                }
                else
                {
                    string[] data = input.Split(new string[] { secondDelimiter }, StringSplitOptions.RemoveEmptyEntries);
                    string coffeeType = data[0];
                    long quantity = long.Parse(data[1]);

                    if (!coffeeQuantityReg.ContainsKey(coffeeType))
                    {
                        coffeeQuantityReg[coffeeType] = quantity;
                    }
                    else
                    {
                        coffeeQuantityReg[coffeeType] += quantity;
                    }

                }
            }

            foreach (var cof in coffeeQuantityReg.Where(x => x.Value <= 0))
            {
                Console.WriteLine($"Out of {cof.Key}");
            }


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of week")
                {
                    break;
                }

                string[] data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string personName = data[0];
                int quantity = int.Parse(data[1]);

                if (clientsReg.ContainsKey(personName))
                {

                    string coffee = clientsReg[personName];
                    coffeeQuantityReg[coffee] -= quantity;

                    if (coffeeQuantityReg[coffee] <= 0)
                    {
                        Console.WriteLine($"Out of {coffee}");
                    }
                }

            }

            Console.WriteLine("Coffee Left:");

            foreach (var pair in coffeeQuantityReg.OrderByDescending(x => x.Value))
            {
                if (pair.Value > 0)
                {
                    Console.WriteLine($"{pair.Key} {pair.Value}");
                }
            }

            Console.WriteLine("For:");

            foreach (var pair in coffeeQuantityReg.OrderBy(x => x.Key))
            {
                if (pair.Value > 0)
                {
                    foreach (var kvp in clientsReg.Where(c => c.Value == pair.Key).OrderByDescending(x => x.Key))
                    {
                        Console.WriteLine($"{kvp.Key} {kvp.Value}");
                    }
                }
            }

        }
    }
}
