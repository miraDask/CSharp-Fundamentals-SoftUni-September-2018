using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSum = 0;
            List<string> furnitures = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Regex regex = new Regex(@">{2}(?<furniture>[A-Z][a-zA-Z]+)<{2}(?<price>[0-9]+(\.[0-9]+)?)!{1}(?<quantity>[0-9]+)");


                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    string furniture = match.Groups["furniture"].Value;

                    furnitures.Add(furniture);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    totalSum += price * quantity;

                }
            }

            Console.WriteLine("Bought furniture:");
            Console.WriteLine(string.Join(Environment.NewLine, furnitures));
            Console.WriteLine($"Total money spend: {totalSum:f2}");

        }
    }
}
