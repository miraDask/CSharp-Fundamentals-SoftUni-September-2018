
namespace _04.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var productsInfo = new Dictionary<string, double[]>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] currentProductInfo = input.Split(' ').ToArray();

                string product = currentProductInfo[0];
                double[] priceQuantityList = currentProductInfo.Skip(1).Select(double.Parse).ToArray();
                double currentPrice = priceQuantityList[0];
                double currentQuantity = priceQuantityList[1];

                if (!productsInfo.ContainsKey(product))
                {
                    productsInfo.Add(product, priceQuantityList);
                }
                else
                {
                    productsInfo[product][1] += currentQuantity;

                    if (currentPrice != productsInfo[product][0])
                    {
                        productsInfo[product][0] = currentPrice;
                    }
                  
                }
            }

            foreach (var product in productsInfo)
            {
                double sum = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {sum:f2} ");
            }
        }
    }
}
