namespace _04.ListOfProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> products = new List<string>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Insert(products.Count, "opala");

            Console.WriteLine(string.Join(" ",products));
            //int countOfProducts = 1;

            //foreach (var product in products.OrderBy(p => p))
            //{
            //    Console.WriteLine($"{countOfProducts}.{product}");
            //    countOfProducts++;
            //}
        }
    }
}
