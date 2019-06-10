
namespace _05.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Product
    {
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }

        public decimal Cost { get; set; }
    }

    public class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<string>();
        }

        public string Name { get; set; }

        public decimal Money { get; set; }

        public List<string> BagOfProducts { get; set; }

        public void ReviseMoney(decimal cost)
        {
            Money -= cost;
        }
    }
    public class Program
    {
        public static void Main()
        {
            List<Person> peopleList = new List<Person>();
            List<Product> productsList = new List<Product>();

            string[] peopleData = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] productData = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < peopleData.Length; i++)
            {
                string[] currentPersonData = peopleData[i].Split('=').ToArray();

                string personName = currentPersonData[0];
                decimal money = decimal.Parse(currentPersonData[1]);
                Person currentPerson = new Person(personName, money);
                peopleList.Add(currentPerson);

            }

            for (int i = 0; i < productData.Length; i++)
            {
                string[] currentProductData = productData[i].Split('=').ToArray();
                string productName = currentProductData[0];
                decimal cost = decimal.Parse(currentProductData[1]);

                Product currentProduct = new Product(productName, cost);
                productsList.Add(currentProduct);

            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] currentInput = input.Split().ToArray();

                string currentPerson = currentInput[0];
                string currentProduct = currentInput[1];

                if (peopleList.Any(p => p.Name == currentPerson) && productsList.Any(pr => pr.Name == currentProduct))
                {
                    int personIndex = peopleList.FindIndex(p => p.Name == currentPerson);
                    Person person = peopleList[personIndex];

                    int productIndex = productsList.FindIndex(p => p.Name == currentProduct);
                    Product product = productsList[productIndex];

                    if (product.Cost <= person.Money)
                    {
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                        person.ReviseMoney(product.Cost);
                        person.BagOfProducts.Add(product.Name);
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    }
                }
            }

            foreach (var person in peopleList)
            {
                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {

                    Console.WriteLine($"{person.Name} - {string.Join(", ",person.BagOfProducts)}");
                }

            }
        }
    }
}
