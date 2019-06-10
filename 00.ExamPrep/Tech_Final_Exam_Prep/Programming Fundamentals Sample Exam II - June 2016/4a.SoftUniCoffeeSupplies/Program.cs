

namespace _4a.SoftUniCoffeeSupplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Coffee
    {
        public Coffee(string type)
        {
            this.Type = type;
            this.Quantity = 0;
            Consumers = new List<string>();
        }
        public string Type { get; set; }

        public long Quantity { get; set; }

        public List<string> Consumers { get; set; } 

    }

    public class Program
    {
        public static void Main()
        {
            List<Coffee> coffeeRegister = new List<Coffee>();

            string[] keywords = Console.ReadLine().Split();

            string firstDelimiter = keywords[0];
            string secondDelimiter = keywords[1];

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

                    if (!coffeeRegister.Any(x => x.Type == coffeeType))
                    {
                        coffeeRegister.Add(new Coffee(coffeeType));

                    }

                    var currentCoffee = coffeeRegister.Find(x => x.Type == coffeeType);
                    currentCoffee.Consumers.Add(personName);

                }
                else
                {
                    string[] data = input.Split(new string[] { secondDelimiter }, StringSplitOptions.RemoveEmptyEntries);
                    string coffeeType = data[0];
                    long quantity = long.Parse(data[1]);

                    if (!coffeeRegister.Any(x => x.Type == coffeeType))
                    {
                        coffeeRegister.Add(new Coffee(coffeeType));

                    }

                    var currentCoffee = coffeeRegister.Find(x => x.Type == coffeeType);
                    currentCoffee.Quantity += quantity;
                }
            }

            foreach (Coffee coffee in coffeeRegister.Where(x => x.Quantity == 0))
            {
                Console.WriteLine($"Out of {coffee}");
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of week")
                {
                    break;
                }

                string[] data = input.Split();

                string personName = data[0];
                int quantity = int.Parse(data[1]);


            }
        }
    }
}
